import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddMovieTvShowComponent } from './add-movie-tv-show.component';

describe('AddMovieTvShowComponent', () => {
  let component: AddMovieTvShowComponent;
  let fixture: ComponentFixture<AddMovieTvShowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddMovieTvShowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddMovieTvShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
