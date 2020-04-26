using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.device']/class[@name='ScanManager']"
	[global::Android.Runtime.Register ("android/device/ScanManager", DoNotGenerateAcw=true)]
	public partial class ScanManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/field[@name='ACTION_DECODE']"
		[Register ("ACTION_DECODE")]
		public const string ActionDecode = (string) "android.intent.ACTION_DECODE_DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/field[@name='BARCODE_LENGTH_TAG']"
		[Register ("BARCODE_LENGTH_TAG")]
		public const string BarcodeLengthTag = (string) "length";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/field[@name='BARCODE_STRING_TAG']"
		[Register ("BARCODE_STRING_TAG")]
		public const string BarcodeStringTag = (string) "barcode_string";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/field[@name='BARCODE_TYPE_TAG']"
		[Register ("BARCODE_TYPE_TAG")]
		public const string BarcodeTypeTag = (string) "barcodeType";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/field[@name='DECODE_DATA_TAG']"
		[Register ("DECODE_DATA_TAG")]
		public const string DecodeDataTag = (string) "barcode";
		static readonly JniPeerMembers _members = new XAPeerMembers ("android/device/ScanManager", typeof (ScanManager));
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

		protected ScanManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/constructor[@name='ScanManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAppendState;
#pragma warning disable 0169
		static Delegate GetGetAppendStateHandler ()
		{
			if (cb_getAppendState == null)
				cb_getAppendState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAppendState);
			return cb_getAppendState;
		}

		static bool n_GetAppendState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppendState;
		}
#pragma warning restore 0169

		public virtual unsafe bool AppendState {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getAppendState' and count(parameter)=0]"
			[Register ("getAppendState", "()Z", "GetGetAppendStateHandler")]
			get {
				const string __id = "getAppendState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBeepState;
#pragma warning disable 0169
		static Delegate GetGetBeepStateHandler ()
		{
			if (cb_getBeepState == null)
				cb_getBeepState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetBeepState);
			return cb_getBeepState;
		}

		static bool n_GetBeepState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BeepState;
		}
#pragma warning restore 0169

		public virtual unsafe bool BeepState {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getBeepState' and count(parameter)=0]"
			[Register ("getBeepState", "()Z", "GetGetBeepStateHandler")]
			get {
				const string __id = "getBeepState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOutputMode;
#pragma warning disable 0169
		static Delegate GetGetOutputModeHandler ()
		{
			if (cb_getOutputMode == null)
				cb_getOutputMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputMode);
			return cb_getOutputMode;
		}

		static int n_GetOutputMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputMode;
		}
#pragma warning restore 0169

		public virtual unsafe int OutputMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getOutputMode' and count(parameter)=0]"
			[Register ("getOutputMode", "()I", "GetGetOutputModeHandler")]
			get {
				const string __id = "getOutputMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScanerList;
#pragma warning disable 0169
		static Delegate GetGetScanerListHandler ()
		{
			if (cb_getScanerList == null)
				cb_getScanerList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScanerList);
			return cb_getScanerList;
		}

		static IntPtr n_GetScanerList (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (__this.ScanerList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> ScanerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getScanerList' and count(parameter)=0]"
			[Register ("getScanerList", "()Ljava/util/Map;", "GetGetScanerListHandler")]
			get {
				const string __id = "getScanerList.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScannerState;
#pragma warning disable 0169
		static Delegate GetGetScannerStateHandler ()
		{
			if (cb_getScannerState == null)
				cb_getScannerState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetScannerState);
			return cb_getScannerState;
		}

		static bool n_GetScannerState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScannerState;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScannerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getScannerState' and count(parameter)=0]"
			[Register ("getScannerState", "()Z", "GetGetScannerStateHandler")]
			get {
				const string __id = "getScannerState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScannerType;
#pragma warning disable 0169
		static Delegate GetGetScannerTypeHandler ()
		{
			if (cb_getScannerType == null)
				cb_getScannerType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScannerType);
			return cb_getScannerType;
		}

		static int n_GetScannerType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScannerType;
		}
#pragma warning restore 0169

		static Delegate cb_setScannerType_I;
#pragma warning disable 0169
		static Delegate GetSetScannerType_IHandler ()
		{
			if (cb_setScannerType_I == null)
				cb_setScannerType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScannerType_I);
			return cb_setScannerType_I;
		}

		static void n_SetScannerType_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScannerType = type;
		}
#pragma warning restore 0169

		public virtual unsafe int ScannerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getScannerType' and count(parameter)=0]"
			[Register ("getScannerType", "()I", "GetGetScannerTypeHandler")]
			get {
				const string __id = "getScannerType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setScannerType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScannerType", "(I)V", "GetSetScannerType_IHandler")]
			set {
				const string __id = "setScannerType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTriggerLockState;
#pragma warning disable 0169
		static Delegate GetGetTriggerLockStateHandler ()
		{
			if (cb_getTriggerLockState == null)
				cb_getTriggerLockState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTriggerLockState);
			return cb_getTriggerLockState;
		}

		static bool n_GetTriggerLockState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TriggerLockState;
		}
#pragma warning restore 0169

		public virtual unsafe bool TriggerLockState {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getTriggerLockState' and count(parameter)=0]"
			[Register ("getTriggerLockState", "()Z", "GetGetTriggerLockStateHandler")]
			get {
				const string __id = "getTriggerLockState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTriggerMode;
#pragma warning disable 0169
		static Delegate GetGetTriggerModeHandler ()
		{
			if (cb_getTriggerMode == null)
				cb_getTriggerMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTriggerMode);
			return cb_getTriggerMode;
		}

		static IntPtr n_GetTriggerMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TriggerMode);
		}
#pragma warning restore 0169

		static Delegate cb_setTriggerMode_Landroid_device_scanner_configuration_Triggering_;
#pragma warning disable 0169
		static Delegate GetSetTriggerMode_Landroid_device_scanner_configuration_Triggering_Handler ()
		{
			if (cb_setTriggerMode_Landroid_device_scanner_configuration_Triggering_ == null)
				cb_setTriggerMode_Landroid_device_scanner_configuration_Triggering_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTriggerMode_Landroid_device_scanner_configuration_Triggering_);
			return cb_setTriggerMode_Landroid_device_scanner_configuration_Triggering_;
		}

		static void n_SetTriggerMode_Landroid_device_scanner_configuration_Triggering_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Device.Scanner.Configuration.Triggering mode = global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Triggering> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.TriggerMode = mode;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Device.Scanner.Configuration.Triggering TriggerMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getTriggerMode' and count(parameter)=0]"
			[Register ("getTriggerMode", "()Landroid/device/scanner/configuration/Triggering;", "GetGetTriggerModeHandler")]
			get {
				const string __id = "getTriggerMode.()Landroid/device/scanner/configuration/Triggering;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Triggering> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setTriggerMode' and count(parameter)=1 and parameter[1][@type='android.device.scanner.configuration.Triggering']]"
			[Register ("setTriggerMode", "(Landroid/device/scanner/configuration/Triggering;)V", "GetSetTriggerMode_Landroid_device_scanner_configuration_Triggering_Handler")]
			set {
				const string __id = "setTriggerMode.(Landroid/device/scanner/configuration/Triggering;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVibrateState;
#pragma warning disable 0169
		static Delegate GetGetVibrateStateHandler ()
		{
			if (cb_getVibrateState == null)
				cb_getVibrateState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetVibrateState);
			return cb_getVibrateState;
		}

		static bool n_GetVibrateState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VibrateState;
		}
#pragma warning restore 0169

		public virtual unsafe bool VibrateState {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getVibrateState' and count(parameter)=0]"
			[Register ("getVibrateState", "()Z", "GetGetVibrateStateHandler")]
			get {
				const string __id = "getVibrateState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_closeScanner;
#pragma warning disable 0169
		static Delegate GetCloseScannerHandler ()
		{
			if (cb_closeScanner == null)
				cb_closeScanner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CloseScanner);
			return cb_closeScanner;
		}

		static bool n_CloseScanner (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseScanner ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='closeScanner' and count(parameter)=0]"
		[Register ("closeScanner", "()Z", "GetCloseScannerHandler")]
		public virtual unsafe bool CloseScanner ()
		{
			const string __id = "closeScanner.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doAck;
#pragma warning disable 0169
		static Delegate GetDoAckHandler ()
		{
			if (cb_doAck == null)
				cb_doAck = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DoAck);
			return cb_doAck;
		}

		static bool n_DoAck (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoAck ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='doAck' and count(parameter)=0]"
		[Register ("doAck", "()Z", "GetDoAckHandler")]
		public virtual unsafe bool DoAck ()
		{
			const string __id = "doAck.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doNack_I;
#pragma warning disable 0169
		static Delegate GetDoNack_IHandler ()
		{
			if (cb_doNack_I == null)
				cb_doNack_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_DoNack_I);
			return cb_doNack_I;
		}

		static bool n_DoNack_I (IntPtr jnienv, IntPtr native__this, int reason)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoNack (reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='doNack' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("doNack", "(I)Z", "GetDoNack_IHandler")]
		public virtual unsafe bool DoNack (int reason)
		{
			const string __id = "doNack.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (reason);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doOpTiConDefaultSet;
#pragma warning disable 0169
		static Delegate GetDoOpTiConDefaultSetHandler ()
		{
			if (cb_doOpTiConDefaultSet == null)
				cb_doOpTiConDefaultSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DoOpTiConDefaultSet);
			return cb_doOpTiConDefaultSet;
		}

		static bool n_DoOpTiConDefaultSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoOpTiConDefaultSet ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='doOpTiConDefaultSet' and count(parameter)=0]"
		[Register ("doOpTiConDefaultSet", "()Z", "GetDoOpTiConDefaultSetHandler")]
		public virtual unsafe bool DoOpTiConDefaultSet ()
		{
			const string __id = "doOpTiConDefaultSet.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doSymbolDefaultSet;
#pragma warning disable 0169
		static Delegate GetDoSymbolDefaultSetHandler ()
		{
			if (cb_doSymbolDefaultSet == null)
				cb_doSymbolDefaultSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DoSymbolDefaultSet);
			return cb_doSymbolDefaultSet;
		}

		static bool n_DoSymbolDefaultSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoSymbolDefaultSet ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='doSymbolDefaultSet' and count(parameter)=0]"
		[Register ("doSymbolDefaultSet", "()Z", "GetDoSymbolDefaultSetHandler")]
		public virtual unsafe bool DoSymbolDefaultSet ()
		{
			const string __id = "doSymbolDefaultSet.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enableAllSymbologies_Z;
#pragma warning disable 0169
		static Delegate GetEnableAllSymbologies_ZHandler ()
		{
			if (cb_enableAllSymbologies_Z == null)
				cb_enableAllSymbologies_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableAllSymbologies_Z);
			return cb_enableAllSymbologies_Z;
		}

		static void n_EnableAllSymbologies_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableAllSymbologies (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='enableAllSymbologies' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableAllSymbologies", "(Z)V", "GetEnableAllSymbologies_ZHandler")]
		public virtual unsafe void EnableAllSymbologies (bool enable)
		{
			const string __id = "enableAllSymbologies.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_enableSymbology_Landroid_device_scanner_configuration_Symbology_Z;
#pragma warning disable 0169
		static Delegate GetEnableSymbology_Landroid_device_scanner_configuration_Symbology_ZHandler ()
		{
			if (cb_enableSymbology_Landroid_device_scanner_configuration_Symbology_Z == null)
				cb_enableSymbology_Landroid_device_scanner_configuration_Symbology_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_EnableSymbology_Landroid_device_scanner_configuration_Symbology_Z);
			return cb_enableSymbology_Landroid_device_scanner_configuration_Symbology_Z;
		}

		static void n_EnableSymbology_Landroid_device_scanner_configuration_Symbology_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_barcodeType, bool enable)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Device.Scanner.Configuration.Symbology barcodeType = global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Symbology> (native_barcodeType, JniHandleOwnership.DoNotTransfer);
			__this.EnableSymbology (barcodeType, enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='enableSymbology' and count(parameter)=2 and parameter[1][@type='android.device.scanner.configuration.Symbology'] and parameter[2][@type='boolean']]"
		[Register ("enableSymbology", "(Landroid/device/scanner/configuration/Symbology;Z)V", "GetEnableSymbology_Landroid_device_scanner_configuration_Symbology_ZHandler")]
		public virtual unsafe void EnableSymbology (global::Android.Device.Scanner.Configuration.Symbology barcodeType, bool enable)
		{
			const string __id = "enableSymbology.(Landroid/device/scanner/configuration/Symbology;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((barcodeType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barcodeType).Handle);
				__args [1] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getOutputParameter_I;
#pragma warning disable 0169
		static Delegate GetGetOutputParameter_IHandler ()
		{
			if (cb_getOutputParameter_I == null)
				cb_getOutputParameter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetOutputParameter_I);
			return cb_getOutputParameter_I;
		}

		static int n_GetOutputParameter_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutputParameter (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getOutputParameter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOutputParameter", "(I)I", "GetGetOutputParameter_IHandler")]
		public virtual unsafe int GetOutputParameter (int type)
		{
			const string __id = "getOutputParameter.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getParameterInts_arrayI;
#pragma warning disable 0169
		static Delegate GetGetParameterInts_arrayIHandler ()
		{
			if (cb_getParameterInts_arrayI == null)
				cb_getParameterInts_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParameterInts_arrayI);
			return cb_getParameterInts_arrayI;
		}

		static IntPtr n_GetParameterInts_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_id_buffer)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] id_buffer = (int[]) JNIEnv.GetArray (native_id_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.GetParameterInts (id_buffer));
			if (id_buffer != null)
				JNIEnv.CopyArray (id_buffer, native_id_buffer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getParameterInts' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getParameterInts", "([I)[I", "GetGetParameterInts_arrayIHandler")]
		public virtual unsafe int[] GetParameterInts (int[] id_buffer)
		{
			const string __id = "getParameterInts.([I)[I";
			IntPtr native_id_buffer = JNIEnv.NewArray (id_buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id_buffer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (id_buffer != null) {
					JNIEnv.CopyArray (native_id_buffer, id_buffer);
					JNIEnv.DeleteLocalRef (native_id_buffer);
				}
			}
		}

		static Delegate cb_getParameterString_arrayI;
#pragma warning disable 0169
		static Delegate GetGetParameterString_arrayIHandler ()
		{
			if (cb_getParameterString_arrayI == null)
				cb_getParameterString_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParameterString_arrayI);
			return cb_getParameterString_arrayI;
		}

		static IntPtr n_GetParameterString_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] index = (int[]) JNIEnv.GetArray (native_index, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.GetParameterString (index));
			if (index != null)
				JNIEnv.CopyArray (index, native_index);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getParameterString' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getParameterString", "([I)[Ljava/lang/String;", "GetGetParameterString_arrayIHandler")]
		public virtual unsafe string[] GetParameterString (int[] index)
		{
			const string __id = "getParameterString.([I)[Ljava/lang/String;";
			IntPtr native_index = JNIEnv.NewArray (index);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				if (index != null) {
					JNIEnv.CopyArray (native_index, index);
					JNIEnv.DeleteLocalRef (native_index);
				}
			}
		}

		static Delegate cb_getPropertyInts_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetGetPropertyInts_arrayIarrayIHandler ()
		{
			if (cb_getPropertyInts_arrayIarrayI == null)
				cb_getPropertyInts_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPropertyInts_arrayIarrayI);
			return cb_getPropertyInts_arrayIarrayI;
		}

		static void n_GetPropertyInts_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_id_buffer, IntPtr native_value_buffer)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] id_buffer = (int[]) JNIEnv.GetArray (native_id_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] value_buffer = (int[]) JNIEnv.GetArray (native_value_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.GetPropertyInts (id_buffer, value_buffer);
			if (id_buffer != null)
				JNIEnv.CopyArray (id_buffer, native_id_buffer);
			if (value_buffer != null)
				JNIEnv.CopyArray (value_buffer, native_value_buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getPropertyInts' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("getPropertyInts", "([I[I)V", "GetGetPropertyInts_arrayIarrayIHandler")]
		public virtual unsafe void GetPropertyInts (int[] id_buffer, int[] value_buffer)
		{
			const string __id = "getPropertyInts.([I[I)V";
			IntPtr native_id_buffer = JNIEnv.NewArray (id_buffer);
			IntPtr native_value_buffer = JNIEnv.NewArray (value_buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id_buffer);
				__args [1] = new JniArgumentValue (native_value_buffer);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (id_buffer != null) {
					JNIEnv.CopyArray (native_id_buffer, id_buffer);
					JNIEnv.DeleteLocalRef (native_id_buffer);
				}
				if (value_buffer != null) {
					JNIEnv.CopyArray (native_value_buffer, value_buffer);
					JNIEnv.DeleteLocalRef (native_value_buffer);
				}
			}
		}

		static Delegate cb_getPropertyString_I;
#pragma warning disable 0169
		static Delegate GetGetPropertyString_IHandler ()
		{
			if (cb_getPropertyString_I == null)
				cb_getPropertyString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPropertyString_I);
			return cb_getPropertyString_I;
		}

		static IntPtr n_GetPropertyString_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetPropertyString (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getPropertyString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPropertyString", "(I)Ljava/lang/String;", "GetGetPropertyString_IHandler")]
		public virtual unsafe string GetPropertyString (int index)
		{
			const string __id = "getPropertyString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getScanPara_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetScanPara_Ljava_lang_String_Handler ()
		{
			if (cb_getScanPara_Ljava_lang_String_ == null)
				cb_getScanPara_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetScanPara_Ljava_lang_String_);
			return cb_getScanPara_Ljava_lang_String_;
		}

		static IntPtr n_GetScanPara_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_para)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string para = JNIEnv.GetString (native_para, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetScanPara (para));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='getScanPara' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getScanPara", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetScanPara_Ljava_lang_String_Handler")]
		public virtual unsafe string GetScanPara (string para)
		{
			const string __id = "getScanPara.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_para = JNIEnv.NewString (para);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_para);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_para);
			}
		}

		static Delegate cb_initOutputMode;
#pragma warning disable 0169
		static Delegate GetInitOutputModeHandler ()
		{
			if (cb_initOutputMode == null)
				cb_initOutputMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InitOutputMode);
			return cb_initOutputMode;
		}

		static bool n_InitOutputMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitOutputMode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='initOutputMode' and count(parameter)=0]"
		[Register ("initOutputMode", "()Z", "GetInitOutputModeHandler")]
		public virtual unsafe bool InitOutputMode ()
		{
			const string __id = "initOutputMode.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_;
#pragma warning disable 0169
		static Delegate GetIsSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_Handler ()
		{
			if (cb_isSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_ == null)
				cb_isSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_);
			return cb_isSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_;
		}

		static bool n_IsSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_ (IntPtr jnienv, IntPtr native__this, IntPtr native_barcodeType)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Device.Scanner.Configuration.Symbology barcodeType = global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Symbology> (native_barcodeType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSymbologyEnabled (barcodeType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='isSymbologyEnabled' and count(parameter)=1 and parameter[1][@type='android.device.scanner.configuration.Symbology']]"
		[Register ("isSymbologyEnabled", "(Landroid/device/scanner/configuration/Symbology;)Z", "GetIsSymbologyEnabled_Landroid_device_scanner_configuration_Symbology_Handler")]
		public virtual unsafe bool IsSymbologyEnabled (global::Android.Device.Scanner.Configuration.Symbology barcodeType)
		{
			const string __id = "isSymbologyEnabled.(Landroid/device/scanner/configuration/Symbology;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((barcodeType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barcodeType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isSymbologySupported_Landroid_device_scanner_configuration_Symbology_;
#pragma warning disable 0169
		static Delegate GetIsSymbologySupported_Landroid_device_scanner_configuration_Symbology_Handler ()
		{
			if (cb_isSymbologySupported_Landroid_device_scanner_configuration_Symbology_ == null)
				cb_isSymbologySupported_Landroid_device_scanner_configuration_Symbology_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSymbologySupported_Landroid_device_scanner_configuration_Symbology_);
			return cb_isSymbologySupported_Landroid_device_scanner_configuration_Symbology_;
		}

		static bool n_IsSymbologySupported_Landroid_device_scanner_configuration_Symbology_ (IntPtr jnienv, IntPtr native__this, IntPtr native_barcodeType)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Device.Scanner.Configuration.Symbology barcodeType = global::Java.Lang.Object.GetObject<global::Android.Device.Scanner.Configuration.Symbology> (native_barcodeType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSymbologySupported (barcodeType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='isSymbologySupported' and count(parameter)=1 and parameter[1][@type='android.device.scanner.configuration.Symbology']]"
		[Register ("isSymbologySupported", "(Landroid/device/scanner/configuration/Symbology;)Z", "GetIsSymbologySupported_Landroid_device_scanner_configuration_Symbology_Handler")]
		public virtual unsafe bool IsSymbologySupported (global::Android.Device.Scanner.Configuration.Symbology barcodeType)
		{
			const string __id = "isSymbologySupported.(Landroid/device/scanner/configuration/Symbology;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((barcodeType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barcodeType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_lockTrigger;
#pragma warning disable 0169
		static Delegate GetLockTriggerHandler ()
		{
			if (cb_lockTrigger == null)
				cb_lockTrigger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LockTrigger);
			return cb_lockTrigger;
		}

		static bool n_LockTrigger (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LockTrigger ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='lockTrigger' and count(parameter)=0]"
		[Register ("lockTrigger", "()Z", "GetLockTriggerHandler")]
		public virtual unsafe bool LockTrigger ()
		{
			const string __id = "lockTrigger.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_lockTriggler;
#pragma warning disable 0169
		static Delegate GetLockTrigglerHandler ()
		{
			if (cb_lockTriggler == null)
				cb_lockTriggler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LockTriggler);
			return cb_lockTriggler;
		}

		static bool n_LockTriggler (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LockTriggler ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='lockTriggler' and count(parameter)=0]"
		[Register ("lockTriggler", "()Z", "GetLockTrigglerHandler")]
		public virtual unsafe bool LockTriggler ()
		{
			const string __id = "lockTriggler.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_open_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_IIHandler ()
		{
			if (cb_open_Ljava_lang_String_II == null)
				cb_open_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Open_Ljava_lang_String_II);
			return cb_open_Ljava_lang_String_II;
		}

		static IntPtr n_Open_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_file, int baudrate, int scantype)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (file, baudrate, scantype));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='open' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("open", "(Ljava/lang/String;II)Ljava/io/FileDescriptor;", "GetOpen_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::Java.IO.FileDescriptor Open (string file, int baudrate, int scantype)
		{
			const string __id = "open.(Ljava/lang/String;II)Ljava/io/FileDescriptor;";
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_file);
				__args [1] = new JniArgumentValue (baudrate);
				__args [2] = new JniArgumentValue (scantype);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		static Delegate cb_openScanner;
#pragma warning disable 0169
		static Delegate GetOpenScannerHandler ()
		{
			if (cb_openScanner == null)
				cb_openScanner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OpenScanner);
			return cb_openScanner;
		}

		static bool n_OpenScanner (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenScanner ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='openScanner' and count(parameter)=0]"
		[Register ("openScanner", "()Z", "GetOpenScannerHandler")]
		public virtual unsafe bool OpenScanner ()
		{
			const string __id = "openScanner.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resetScannerParameters;
#pragma warning disable 0169
		static Delegate GetResetScannerParametersHandler ()
		{
			if (cb_resetScannerParameters == null)
				cb_resetScannerParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ResetScannerParameters);
			return cb_resetScannerParameters;
		}

		static bool n_ResetScannerParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResetScannerParameters ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='resetScannerParameters' and count(parameter)=0]"
		[Register ("resetScannerParameters", "()Z", "GetResetScannerParametersHandler")]
		public virtual unsafe bool ResetScannerParameters ()
		{
			const string __id = "resetScannerParameters.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resetScannerParameters_I;
#pragma warning disable 0169
		static Delegate GetResetScannerParameters_IHandler ()
		{
			if (cb_resetScannerParameters_I == null)
				cb_resetScannerParameters_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_ResetScannerParameters_I);
			return cb_resetScannerParameters_I;
		}

		static bool n_ResetScannerParameters_I (IntPtr jnienv, IntPtr native__this, int scantyp)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResetScannerParameters (scantyp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='resetScannerParameters' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resetScannerParameters", "(I)Z", "GetResetScannerParameters_IHandler")]
		public virtual unsafe bool ResetScannerParameters (int scantyp)
		{
			const string __id = "resetScannerParameters.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scantyp);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setAppend;
#pragma warning disable 0169
		static Delegate GetSetAppendHandler ()
		{
			if (cb_setAppend == null)
				cb_setAppend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetAppend);
			return cb_setAppend;
		}

		static bool n_SetAppend (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAppend ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setAppend' and count(parameter)=0]"
		[Register ("setAppend", "()Z", "GetSetAppendHandler")]
		public virtual unsafe bool SetAppend ()
		{
			const string __id = "setAppend.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setBeep;
#pragma warning disable 0169
		static Delegate GetSetBeepHandler ()
		{
			if (cb_setBeep == null)
				cb_setBeep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetBeep);
			return cb_setBeep;
		}

		static bool n_SetBeep (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetBeep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setBeep' and count(parameter)=0]"
		[Register ("setBeep", "()Z", "GetSetBeepHandler")]
		public virtual unsafe bool SetBeep ()
		{
			const string __id = "setBeep.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setOutputParameter_II;
#pragma warning disable 0169
		static Delegate GetSetOutputParameter_IIHandler ()
		{
			if (cb_setOutputParameter_II == null)
				cb_setOutputParameter_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_SetOutputParameter_II);
			return cb_setOutputParameter_II;
		}

		static bool n_SetOutputParameter_II (IntPtr jnienv, IntPtr native__this, int type, int value)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetOutputParameter (type, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setOutputParameter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setOutputParameter", "(II)Z", "GetSetOutputParameter_IIHandler")]
		public virtual unsafe bool SetOutputParameter (int type, int value)
		{
			const string __id = "setOutputParameter.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setParameterInts_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetSetParameterInts_arrayIarrayIHandler ()
		{
			if (cb_setParameterInts_arrayIarrayI == null)
				cb_setParameterInts_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SetParameterInts_arrayIarrayI);
			return cb_setParameterInts_arrayIarrayI;
		}

		static int n_SetParameterInts_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_id_buffer, IntPtr native_value_buffer)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] id_buffer = (int[]) JNIEnv.GetArray (native_id_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] value_buffer = (int[]) JNIEnv.GetArray (native_value_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.SetParameterInts (id_buffer, value_buffer);
			if (id_buffer != null)
				JNIEnv.CopyArray (id_buffer, native_id_buffer);
			if (value_buffer != null)
				JNIEnv.CopyArray (value_buffer, native_value_buffer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setParameterInts' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("setParameterInts", "([I[I)I", "GetSetParameterInts_arrayIarrayIHandler")]
		public virtual unsafe int SetParameterInts (int[] id_buffer, int[] value_buffer)
		{
			const string __id = "setParameterInts.([I[I)I";
			IntPtr native_id_buffer = JNIEnv.NewArray (id_buffer);
			IntPtr native_value_buffer = JNIEnv.NewArray (value_buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id_buffer);
				__args [1] = new JniArgumentValue (native_value_buffer);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (id_buffer != null) {
					JNIEnv.CopyArray (native_id_buffer, id_buffer);
					JNIEnv.DeleteLocalRef (native_id_buffer);
				}
				if (value_buffer != null) {
					JNIEnv.CopyArray (native_value_buffer, value_buffer);
					JNIEnv.DeleteLocalRef (native_value_buffer);
				}
			}
		}

		static Delegate cb_setParameterString_arrayIarrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameterString_arrayIarrayLjava_lang_String_Handler ()
		{
			if (cb_setParameterString_arrayIarrayLjava_lang_String_ == null)
				cb_setParameterString_arrayIarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetParameterString_arrayIarrayLjava_lang_String_);
			return cb_setParameterString_arrayIarrayLjava_lang_String_;
		}

		static bool n_SetParameterString_arrayIarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_value)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] index = (int[]) JNIEnv.GetArray (native_index, JniHandleOwnership.DoNotTransfer, typeof (int));
			string[] value = (string[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (string));
			bool __ret = __this.SetParameterString (index, value);
			if (index != null)
				JNIEnv.CopyArray (index, native_index);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setParameterString' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("setParameterString", "([I[Ljava/lang/String;)Z", "GetSetParameterString_arrayIarrayLjava_lang_String_Handler")]
		public virtual unsafe bool SetParameterString (int[] index, string[] value)
		{
			const string __id = "setParameterString.([I[Ljava/lang/String;)Z";
			IntPtr native_index = JNIEnv.NewArray (index);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_index);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (index != null) {
					JNIEnv.CopyArray (native_index, index);
					JNIEnv.DeleteLocalRef (native_index);
				}
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setPropertyInts_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetSetPropertyInts_arrayIarrayIHandler ()
		{
			if (cb_setPropertyInts_arrayIarrayI == null)
				cb_setPropertyInts_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SetPropertyInts_arrayIarrayI);
			return cb_setPropertyInts_arrayIarrayI;
		}

		static int n_SetPropertyInts_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_id_buffer, IntPtr native_value_buffer)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] id_buffer = (int[]) JNIEnv.GetArray (native_id_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] value_buffer = (int[]) JNIEnv.GetArray (native_value_buffer, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.SetPropertyInts (id_buffer, value_buffer);
			if (id_buffer != null)
				JNIEnv.CopyArray (id_buffer, native_id_buffer);
			if (value_buffer != null)
				JNIEnv.CopyArray (value_buffer, native_value_buffer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setPropertyInts' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("setPropertyInts", "([I[I)I", "GetSetPropertyInts_arrayIarrayIHandler")]
		public virtual unsafe int SetPropertyInts (int[] id_buffer, int[] value_buffer)
		{
			const string __id = "setPropertyInts.([I[I)I";
			IntPtr native_id_buffer = JNIEnv.NewArray (id_buffer);
			IntPtr native_value_buffer = JNIEnv.NewArray (value_buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id_buffer);
				__args [1] = new JniArgumentValue (native_value_buffer);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (id_buffer != null) {
					JNIEnv.CopyArray (native_id_buffer, id_buffer);
					JNIEnv.DeleteLocalRef (native_id_buffer);
				}
				if (value_buffer != null) {
					JNIEnv.CopyArray (native_value_buffer, value_buffer);
					JNIEnv.DeleteLocalRef (native_value_buffer);
				}
			}
		}

		static Delegate cb_setPropertyString_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPropertyString_ILjava_lang_String_Handler ()
		{
			if (cb_setPropertyString_ILjava_lang_String_ == null)
				cb_setPropertyString_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_SetPropertyString_ILjava_lang_String_);
			return cb_setPropertyString_ILjava_lang_String_;
		}

		static bool n_SetPropertyString_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_value)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPropertyString (index, value);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setPropertyString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setPropertyString", "(ILjava/lang/String;)Z", "GetSetPropertyString_ILjava_lang_String_Handler")]
		public virtual unsafe bool SetPropertyString (int index, string value)
		{
			const string __id = "setPropertyString.(ILjava/lang/String;)Z";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setUnAppend;
#pragma warning disable 0169
		static Delegate GetSetUnAppendHandler ()
		{
			if (cb_setUnAppend == null)
				cb_setUnAppend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetUnAppend);
			return cb_setUnAppend;
		}

		static bool n_SetUnAppend (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetUnAppend ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setUnAppend' and count(parameter)=0]"
		[Register ("setUnAppend", "()Z", "GetSetUnAppendHandler")]
		public virtual unsafe bool SetUnAppend ()
		{
			const string __id = "setUnAppend.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setUnBeep;
#pragma warning disable 0169
		static Delegate GetSetUnBeepHandler ()
		{
			if (cb_setUnBeep == null)
				cb_setUnBeep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetUnBeep);
			return cb_setUnBeep;
		}

		static bool n_SetUnBeep (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetUnBeep ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setUnBeep' and count(parameter)=0]"
		[Register ("setUnBeep", "()Z", "GetSetUnBeepHandler")]
		public virtual unsafe bool SetUnBeep ()
		{
			const string __id = "setUnBeep.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setUnVibrate;
#pragma warning disable 0169
		static Delegate GetSetUnVibrateHandler ()
		{
			if (cb_setUnVibrate == null)
				cb_setUnVibrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetUnVibrate);
			return cb_setUnVibrate;
		}

		static bool n_SetUnVibrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetUnVibrate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setUnVibrate' and count(parameter)=0]"
		[Register ("setUnVibrate", "()Z", "GetSetUnVibrateHandler")]
		public virtual unsafe bool SetUnVibrate ()
		{
			const string __id = "setUnVibrate.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setVibrate;
#pragma warning disable 0169
		static Delegate GetSetVibrateHandler ()
		{
			if (cb_setVibrate == null)
				cb_setVibrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetVibrate);
			return cb_setVibrate;
		}

		static bool n_SetVibrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetVibrate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='setVibrate' and count(parameter)=0]"
		[Register ("setVibrate", "()Z", "GetSetVibrateHandler")]
		public virtual unsafe bool SetVibrate ()
		{
			const string __id = "setVibrate.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startDecode;
#pragma warning disable 0169
		static Delegate GetStartDecodeHandler ()
		{
			if (cb_startDecode == null)
				cb_startDecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartDecode);
			return cb_startDecode;
		}

		static bool n_StartDecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDecode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='startDecode' and count(parameter)=0]"
		[Register ("startDecode", "()Z", "GetStartDecodeHandler")]
		public virtual unsafe bool StartDecode ()
		{
			const string __id = "startDecode.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopDecode;
#pragma warning disable 0169
		static Delegate GetStopDecodeHandler ()
		{
			if (cb_stopDecode == null)
				cb_stopDecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopDecode);
			return cb_stopDecode;
		}

		static bool n_StopDecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopDecode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='stopDecode' and count(parameter)=0]"
		[Register ("stopDecode", "()Z", "GetStopDecodeHandler")]
		public virtual unsafe bool StopDecode ()
		{
			const string __id = "stopDecode.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_switchOutputMode_I;
#pragma warning disable 0169
		static Delegate GetSwitchOutputMode_IHandler ()
		{
			if (cb_switchOutputMode_I == null)
				cb_switchOutputMode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SwitchOutputMode_I);
			return cb_switchOutputMode_I;
		}

		static bool n_SwitchOutputMode_I (IntPtr jnienv, IntPtr native__this, int mode)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwitchOutputMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='switchOutputMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("switchOutputMode", "(I)Z", "GetSwitchOutputMode_IHandler")]
		public virtual unsafe bool SwitchOutputMode (int mode)
		{
			const string __id = "switchOutputMode.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toHexString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToHexString (string s)
		{
			const string __id = "toHexString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_unlockTrigger;
#pragma warning disable 0169
		static Delegate GetUnlockTriggerHandler ()
		{
			if (cb_unlockTrigger == null)
				cb_unlockTrigger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnlockTrigger);
			return cb_unlockTrigger;
		}

		static bool n_UnlockTrigger (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnlockTrigger ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='unlockTrigger' and count(parameter)=0]"
		[Register ("unlockTrigger", "()Z", "GetUnlockTriggerHandler")]
		public virtual unsafe bool UnlockTrigger ()
		{
			const string __id = "unlockTrigger.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unlockTriggler;
#pragma warning disable 0169
		static Delegate GetUnlockTrigglerHandler ()
		{
			if (cb_unlockTriggler == null)
				cb_unlockTriggler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UnlockTriggler);
			return cb_unlockTriggler;
		}

		static bool n_UnlockTriggler (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Device.ScanManager __this = global::Java.Lang.Object.GetObject<global::Android.Device.ScanManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnlockTriggler ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.device']/class[@name='ScanManager']/method[@name='unlockTriggler' and count(parameter)=0]"
		[Register ("unlockTriggler", "()Z", "GetUnlockTrigglerHandler")]
		public virtual unsafe bool UnlockTriggler ()
		{
			const string __id = "unlockTriggler.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
