using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizAppXamarin.Activities
{
    [Activity(Label = "QuizActivity")]
    public class QuizActivity : AppCompatActivity
    {
        
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        // Radiu Buttons
        RadioButton optionARadio, optionBRadio, optionCRadio, optionDRadio;

        // TextViews
        TextView optionATextView, optionBTextView, optionCTextView, optionDTextView, questionTextView, quizPositionTextView, timeCounterTextView;

        // Button
        Button proceedQuizButton;

        string quizTopic;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.quiz_page);

            quizTopic = Intent.GetStringExtra("topic");

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.quizToolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = quizTopic + " Quiz";

            AndroidX.AppCompat.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.outline_arrowback);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            ConnectViews();
        }

        void ConnectViews()
        {
            // Radio Buttons
            optionARadio = (RadioButton)FindViewById(Resource.Id.optionARadio);
            optionBRadio = (RadioButton)FindViewById(Resource.Id.optionBRadio);
            optionCRadio = (RadioButton)FindViewById(Resource.Id.optionCRadio);
            optionDRadio = (RadioButton)FindViewById(Resource.Id.optionDRadio);

            // TextViews
            optionATextView = (TextView)FindViewById(Resource.Id.optionATextView);
            optionBTextView = (TextView)FindViewById(Resource.Id.optionBTextView);
            optionCTextView = (TextView)FindViewById(Resource.Id.optionCTextView);
            optionDTextView = (TextView)FindViewById(Resource.Id.optionDTextView);
            questionTextView = (TextView)FindViewById(Resource.Id.questionTextView);
            quizPositionTextView = (TextView)FindViewById(Resource.Id.quizPositionTextView);
            timeCounterTextView = (TextView)FindViewById(Resource.Id.timeCounterTextView);

            // Button
            proceedQuizButton = (Button)FindViewById(Resource.Id.proceedQuizButton);
        }
    }
}