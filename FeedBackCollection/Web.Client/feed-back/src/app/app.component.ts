import { Component } from '@angular/core';
import { TreeNode } from 'primeng/api';
import { FeedbackService } from "./service/feedback.service";
import { first } from 'rxjs/operators';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'feed-back';
  files: TreeNode[];

  cols: any[];
  list:any;
  constructor(private feedbackService: FeedbackService) { }
  ngOnInit() {
   
    this.cols = [
      { field: 'Post', header: 'Post' },
      { field: 'Comment', header: 'Comment' },
      { field: 'Time', header: 'Time' },
      { field: 'Like', header: 'Like' },
      { field: 'Dislike', header: 'Dislike' },
     
    ];

    this.getGridData();
  }

  getGridData() {
    this.feedbackService.getGridData()
      .pipe(first())
      .subscribe(
        data => {
          this.list = data;
        },
        error => {
          console.log(error);
        });
  }
}
