import { TestBed } from '@angular/core/testing';
import { AppComponent } from './app.component';

describe('AppComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        AppComponent
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have a default counter value of zero`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.counterValue).toEqual(0);
  });

  it(`should increment the counter value on click`, () => {
    const fixture = TestBed.createComponent(AppComponent)
    const app = fixture.componentInstance

    app.onclick()
    app.onclick()
    app.onclick()

    expect(app.counterValue).toEqual(3);
  });
});
