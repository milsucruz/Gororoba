import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsRecipeModalComponent } from './details-recipe-modal.component';

describe('DetailsRecipeModalComponent', () => {
  let component: DetailsRecipeModalComponent;
  let fixture: ComponentFixture<DetailsRecipeModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DetailsRecipeModalComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailsRecipeModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
