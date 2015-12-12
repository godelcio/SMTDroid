
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SMTDroid
{
	[Activity (Label = "Menu")]			
	public class Menu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "Menu" layout resource
			SetContentView (Resource.Layout.Menu);

			// Get parameter from previous activity
			string userId = Intent.GetStringExtra ("user_id") ?? "-1";

			// Handle buttons
			// Event
			Button btEvents = FindViewById<Button> (Resource.Id.btEvents);
			btEvents.Click += delegate {
				var intent = new Intent (this, typeof(Events));
				intent.PutExtra("user_id", userId);
				StartActivity (intent);
			};
			// People
			Button btPeople = FindViewById<Button> (Resource.Id.btPeople);
			btPeople.Click += delegate {
				var intent = new Intent(this, typeof(People));
				intent.PutExtra("user_id", userId);
				StartActivity(intent);
			};
			// Events I attended
			Button btEventsAttended = FindViewById<Button> (Resource.Id.btEventsAttended);
			btEventsAttended.Click += delegate {
				var intent = new Intent(this, typeof(EventsAttended));
				intent.PutExtra("user_id", userId);
				StartActivity(intent);
			};
			// People I met
			Button btPeopleMet = FindViewById<Button> (Resource.Id.btPeopleMet);
			btPeopleMet.Click += delegate {
				var intent = new Intent(this, typeof(PeopleMet));
				intent.PutExtra("user_id", userId);
				StartActivity(intent);
			};
			// Logout
			Button btLogout = FindViewById<Button> (Resource.Id.btLogout);
			btLogout.Click += delegate {
				var intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};
		}
	}
}

