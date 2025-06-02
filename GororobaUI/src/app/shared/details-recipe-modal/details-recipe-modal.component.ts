import { Component, Inject, inject, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

interface ExtendedIngredient {
  original: string;
}

interface RecipeDetailsDTO {
  title: string;
  image: string;
  readyInMinutes: number;
  cookingMinutes?: number;
  servings: number;
  summary: string;
  instructions: string;
  extendedIngredients: ExtendedIngredient[];
}

@Component({
  selector: 'app-details-recipe-modal',
  imports: [],
  templateUrl: './details-recipe-modal.component.html',
  styleUrl: './details-recipe-modal.component.css'
})

export class DetailsRecipeModalComponent {
  recipe: RecipeDetailsDTO | null = null;
  loading = true;

  private http = inject(HttpClient);

  constructor(@Inject(MAT_DIALOG_DATA) public data: {recipeId: number}){}

  ngOnInit(): void {
    const url = `/api/gororoba/details/${this.data.recipeId}`

    this.http.get<RecipeDetailsDTO>(url).subscribe({
      next: (data) => {
        this.recipe = data;
        this.loading = false;
      },
      error: (err) =>{
        console.log('Recipe not found', err);
        this.loading = false;
      }
    });
  }
}
