using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Device.Scanner.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']"
	[global::Android.Runtime.Register ("android/device/scanner/configuration/Triggering", DoNotGenerateAcw=true)]
	public sealed partial class Triggering : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']/field[@name='CONTINUOUS']"
		[Register ("CONTINUOUS")]
		public static global::Android.Device.Scanner.Configuration.Triggering Continuous {
			get {
				const string __id = "CONTINUOUS.Landroid/device/scanner/configuration/Triggering;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Triggering> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']/field[@name='HOST']"
		[Register ("HOST")]
		public static global::Android.Device.Scanner.Configuration.Triggering Host {
			get {
				const string __id = "HOST.Landroid/device/scanner/configuration/Triggering;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Triggering> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']/field[@name='PULSE']"
		[Register ("PULSE")]
		public static global::Android.Device.Scanner.Configuration.Triggering Pulse {
			get {
				const string __id = "PULSE.Landroid/device/scanner/configuration/Triggering;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Triggering> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("android/device/scanner/configuration/Triggering", typeof (Triggering));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal Triggering (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']/method[@name='toInt' and count(parameter)=0]"
		[Register ("toInt", "()I", "")]
		public unsafe int ToInt ()
		{
			const string __id = "toInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Landroid/device/scanner/configuration/Triggering;", "")]
		public static unsafe global::Android.Device.Scanner.Configuration.Triggering ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Landroid/device/scanner/configuration/Triggering;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Triggering> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device.scanner.configuration']/class[@name='Triggering']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Landroid/device/scanner/configuration/Triggering;", "")]
		public static unsafe global::Android.Device.Scanner.Configuration.Triggering[] Values ()
		{
			const string __id = "values.()[Landroid/device/scanner/configuration/Triggering;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Android.Device.Scanner.Configuration.Triggering[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.Device.Scanner.Configuration.Triggering));
			} finally {
			}
		}

	}
}
