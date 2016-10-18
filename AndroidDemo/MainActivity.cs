using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidDemo
{
    [Activity(Label = "AndroidDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button button1;
        private TextView textView1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Deze regel is nodig om de Main layout (in map \Resources\layout) te koppelen
            this.SetContentView(Resource.Layout.Main);

            // Vervolgens koppelen we de elementen button1 en textView1 in de layout met objecten in de code
            button1 = this.FindViewById<Button>(Resource.Id.button1);
            textView1 = this.FindViewById<TextView>(Resource.Id.textView1);

            // We maken een instantie van een eigen gedefinieerde klasse
            // De klasse bevindt zich in de namespace AndroidDemo.Entities
            AndroidDemo.Entities.Mural mural1 = new AndroidDemo.Entities.Mural();

            // Met deze code maken we een delegate aan (een soort object met daarin uitvoerbare code)
            // Deze delegate wordt gekoppeld aan de Click event van button1
            button1.Click += delegate { textView1.Text = mural1.GetNaam(); };
        }
    }
}

