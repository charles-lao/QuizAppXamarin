using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using QuizAppXamarin.Activities;

namespace QuizAppXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;

        LinearLayout historyLayout;
        LinearLayout spaceLayout;
        LinearLayout geographyLayout;
        LinearLayout engineeringLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar);

            // Setup toolbar
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Topics";

            AndroidX.AppCompat.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);


            // View Setups
            historyLayout = (LinearLayout)FindViewById(Resource.Id.historyLayout);
            spaceLayout = (LinearLayout)FindViewById(Resource.Id.spaceLayout);
            geographyLayout = (LinearLayout)FindViewById(Resource.Id.geographyLayout);
            engineeringLayout = (LinearLayout)FindViewById(Resource.Id.engineeringLayout);
            programmingLayout = (LinearLayout)FindViewById(Resource.Id.programmingLayout);
            businessLayout = (LinearLayout)FindViewById(Resource.Id.businessLayout);

            // Click Event Handlers
            historyLayout.Click += HistoryLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }
    }
}