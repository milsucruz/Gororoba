import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { MainCardComponent } from '../../shared/main-card/main-card.component';

interface RecipeSearhDTO{
  id: number;
  title: string;
  image: string;
}

@Component({
  selector: 'app-home',
  imports: [CommonModule, ReactiveFormsModule, MainCardComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  searchControl = new FormControl('');
  recipes: RecipeSearhDTO[] | null = null;

  constructor(private http: HttpClient) {}

  GetRecipesByIngredient(){
    const searchQuery = this.searchControl.value?.trim();

    if(searchQuery){
      const url = `/api/gororoba/search?query=${searchQuery}`;
      
      this.http.get<RecipeSearhDTO[]>(url).subscribe({
        next: (data) => this.recipes = data || [],
        error: (err) => {
          console.log('Error when searching for recipes:', err);
          this.recipes = [];
        }      
      });
    } else{
      this.recipes = null;
      console.log('Type in someting to search for');
    }
  }
}
