import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DetailsRecipeModalComponent } from '../details-recipe-modal/details-recipe-modal.component';

@Component({
  selector: 'app-main-card',
  imports: [],
  templateUrl: './main-card.component.html',
  styleUrl: './main-card.component.css'
})
export class MainCardComponent {
@Input() recipeTitle!: string;
@Input() imageUrl!: string;
@Input() recipeId!: number;

constructor(private dialog: MatDialog){};

ShowRecipeDetails(): void {
  this.dialog.open(DetailsRecipeModalComponent,{
    data: { recipeId: this.recipeId }
  });
}
}
