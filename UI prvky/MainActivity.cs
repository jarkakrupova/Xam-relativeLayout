﻿using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace UI_prvky
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnButton;
        TextView lbPopisek;
        CheckBox cbCheckbox;
        EditText tbText;
        Switch swPrepinac;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            SetupReferences();
            SubscribeEventHandlers();
        }

        private void SubscribeEventHandlers() {
            btnButton.Click += BtnButton_Click;
            cbCheckbox.Click += CbCheckbox_Click;
            tbText.Click += TbText_Click;
            swPrepinac.Click += SwPrepinac_Click;
        }

        private void SwPrepinac_Click(object sender, System.EventArgs e) {
            if (swPrepinac.Checked) {
                lbPopisek.Text = "Switch je v poloze ON";
            }
            else {
                lbPopisek.Text = "Switch je v poloze OFF";
            }
        }

        private void SetupReferences() {
            btnButton = FindViewById<Button>(Resource.Id.btnButton);
            lbPopisek = FindViewById<TextView>(Resource.Id.lbPopisek);
            cbCheckbox = FindViewById<CheckBox>(Resource.Id.cbCheckbox);
            tbText = FindViewById<EditText>(Resource.Id.tbText);
            swPrepinac = FindViewById<Switch>(Resource.Id.swPrepinac);
        }

        private void TbText_Click(object sender, System.EventArgs e) {
            lbPopisek.Text = "Zacina se psat do textoveho pole (EditText)";
        }

        private void CbCheckbox_Click(object sender, System.EventArgs e) {
            if (cbCheckbox.Checked) {
                lbPopisek.Text = "Checkbox je zakliknuty";
            }
            else {
                lbPopisek.Text = "Checkbox neni zakliknuty";
            }
        }

        private void BtnButton_Click(object sender, System.EventArgs e) {
            lbPopisek.Text = "Bylo kliknuto na tlacitko.";
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}