using System;
using Android.App;
using Android.Content;
using Android.Device;
using Android.Device.Scanner.Configuration;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using static Android.Widget.RadioGroup;

namespace Xamarin_Scanner_example
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        MySampleBroadcastReceiver receiver;
        public EditText edittext;
        Button startScan, stopScan;
        private ScanManager mScanManager;
        RadioGroup mRadioGroup;
        int[] idbuf = new int[] { PropertyID.WedgeIntentActionName, PropertyID.WedgeIntentDataStringTag };
        int[] idmodebuf = new int[] { PropertyID.WedgeKeyboardEnable, PropertyID.SendGoodReadBeepEnable, PropertyID.TriggeringModes };
        String[] action_value_buf = new String[] { ScanManager.ActionDecode, ScanManager.BarcodeStringTag };
        int[] idmode = new int[3];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            startScan = FindViewById<Button>(Resource.Id.button1);
            startScan.Click += StartScan_Click;
            stopScan = FindViewById<Button>(Resource.Id.button2);
            stopScan.Click += StopScan_Click;
            edittext = FindViewById<EditText>(Resource.Id.edittext);
            edittext.KeyPress += (object sender, View.KeyEventArgs e) => {
                e.Handled = false;
                if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
                {
                    Toast.MakeText(this, edittext.Text, ToastLength.Short).Show();
                    e.Handled = true;
                } else if (e.Event.Action == KeyEventActions.Up && e.KeyCode == Keycode.Enter)
                {
                    edittext.Text = "";
                    e.Handled = true;
                }
            };
            mRadioGroup = FindViewById<RadioGroup>(Resource.Id.mode_output);
            mRadioGroup.CheckedChange += delegate (object sender, RadioGroup.CheckedChangeEventArgs e) {

                switch (e.CheckedId)
                {
                    case Resource.Id.intent_output:
                        idmode[0] = 0;
                        mScanManager.SetPropertyInts(idmodebuf, idmode);
                        //scanResult.setVisibility(View.GONE);
                        break;
                    case Resource.Id.keyboard_output:
                        idmode[0] = 1;
                        idmode[1] = 2;
                        mScanManager.SetPropertyInts(idmodebuf, idmode);
                        //scanResult.setVisibility(View.VISIBLE);
                        //scanResult.requestFocus();
                        break;
                }
            }; 
            mScanManager = new ScanManager();
            mScanManager.GetPropertyInts(idmodebuf, idmode);
            receiver = new MySampleBroadcastReceiver();
        }
        
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void StartScan_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
            mScanManager.StartDecode();
        }
        private void StopScan_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            mScanManager.StopDecode();
        }
         
    protected override void OnResume()
        {
            base.OnResume();
            RegisterReceiver(receiver, new Android.Content.IntentFilter(ScanManager.ActionDecode));
            // Code omitted for clarity
            mScanManager.OpenScanner();
        }

        protected override void OnPause()
        {
            UnregisterReceiver(receiver);
            // Code omitted for clarity
            base.OnPause();
        }
        [BroadcastReceiver(Enabled = true)]
        [IntentFilter(new[] { ScanManager.ActionDecode })]
        public class MySampleBroadcastReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {
                // Do stuff here
                byte[] barcode = intent.GetByteArrayExtra(ScanManager.DecodeDataTag);
                int barcodelen = intent.GetIntExtra(ScanManager.BarcodeLengthTag, 0);
                sbyte temp = intent.GetByteExtra(ScanManager.BarcodeTypeTag, 0x00);
                String result = intent.GetStringExtra(ScanManager.BarcodeStringTag);

                if (result != null)
                {
                    Toast.MakeText(Application.Context, result, ToastLength.Short).Show(); //
                   // edittext.SetText( result.ToCharArray, 0, "" + result.Length);
                }
            }
        }
    }
    
    
}

