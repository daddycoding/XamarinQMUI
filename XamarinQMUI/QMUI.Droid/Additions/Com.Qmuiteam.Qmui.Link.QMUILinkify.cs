using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Link {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/QMUILinkify", DoNotGenerateAcw=true)]
	public partial class QMUILinkify : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='ALL']"
		[Register ("ALL")]
		public const int All = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='EMAIL_ADDRESSES']"
		[Register ("EMAIL_ADDRESSES")]
		public const int EmailAddresses = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='MAP_ADDRESSES']"
		[Register ("MAP_ADDRESSES")]
		public const int MapAddresses = (int) 8;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='NOT_PHONE']"
		[Register ("NOT_PHONE")]
		public static global::Java.Util.Regex.Pattern NotPhone {
			get {
				const string __id = "NOT_PHONE.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='PHONE_NUMBERS']"
		[Register ("PHONE_NUMBERS")]
		public const int PhoneNumbers = (int) 4;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='QMUI_WEB_URL_MATCHER']"
		[Register ("QMUI_WEB_URL_MATCHER")]
		public static global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IWebUrlMatcher QmuiWebUrlMatcher {
			get {
				const string __id = "QMUI_WEB_URL_MATCHER.Lcom/qmuiteam/qmui/link/QMUILinkify$WebUrlMatcher;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IWebUrlMatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='WEB_URLS']"
		[Register ("WEB_URLS")]
		public const int WebUrls = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='WECHAT_PHONE']"
		[Register ("WECHAT_PHONE")]
		public static global::Java.Util.Regex.Pattern WechatPhone {
			get {
				const string __id = "WECHAT_PHONE.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='sPhoneNumberMatchFilter']"
		[Register ("sPhoneNumberMatchFilter")]
		public static global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter SPhoneNumberMatchFilter {
			get {
				const string __id = "sPhoneNumberMatchFilter.Lcom/qmuiteam/qmui/link/QMUILinkify$MatchFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='sPhoneNumberTransformFilter']"
		[Register ("sPhoneNumberTransformFilter")]
		public static global::Com.Qmuiteam.Qmui.Link.QMUILinkify.ITransformFilter SPhoneNumberTransformFilter {
			get {
				const string __id = "sPhoneNumberTransformFilter.Lcom/qmuiteam/qmui/link/QMUILinkify$TransformFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.ITransformFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/field[@name='sUrlMatchFilter']"
		[Register ("sUrlMatchFilter")]
		public static global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter SUrlMatchFilter {
			get {
				const string __id = "sUrlMatchFilter.Lcom/qmuiteam/qmui/link/QMUILinkify$MatchFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='QMUILinkify.MatchFilter']"
		[Register ("com/qmuiteam/qmui/link/QMUILinkify$MatchFilter", "", "Com.Qmuiteam.Qmui.Link.QMUILinkify/IMatchFilterInvoker")]
		public partial interface IMatchFilter : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='QMUILinkify.MatchFilter']/method[@name='acceptMatch' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("acceptMatch", "(Ljava/lang/CharSequence;II)Z", "GetAcceptMatch_Ljava_lang_CharSequence_IIHandler:Com.Qmuiteam.Qmui.Link.QMUILinkify/IMatchFilterInvoker, QMUI.Droid")]
			bool AcceptMatch (global::Java.Lang.ICharSequence s, int start, int end);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/QMUILinkify$MatchFilter", DoNotGenerateAcw=true)]
		internal partial class IMatchFilterInvoker : global::Java.Lang.Object, IMatchFilter {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/QMUILinkify$MatchFilter", typeof (IMatchFilterInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IMatchFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMatchFilter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.link.QMUILinkify.MatchFilter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMatchFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_acceptMatch_Ljava_lang_CharSequence_II;
#pragma warning disable 0169
			static Delegate GetAcceptMatch_Ljava_lang_CharSequence_IIHandler ()
			{
				if (cb_acceptMatch_Ljava_lang_CharSequence_II == null)
					cb_acceptMatch_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_AcceptMatch_Ljava_lang_CharSequence_II);
				return cb_acceptMatch_Ljava_lang_CharSequence_II;
			}

			static bool n_AcceptMatch_Ljava_lang_CharSequence_II (IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int end)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var s = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_s, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AcceptMatch (s, start, end);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_acceptMatch_Ljava_lang_CharSequence_II;
			public unsafe bool AcceptMatch (global::Java.Lang.ICharSequence s, int start, int end)
			{
				if (id_acceptMatch_Ljava_lang_CharSequence_II == IntPtr.Zero)
					id_acceptMatch_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID (class_ref, "acceptMatch", "(Ljava/lang/CharSequence;II)Z");
				IntPtr native_s = CharSequence.ToLocalJniHandle (s);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (start);
				__args [2] = new JValue (end);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_acceptMatch_Ljava_lang_CharSequence_II, __args);
				JNIEnv.DeleteLocalRef (native_s);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='QMUILinkify.TransformFilter']"
		[Register ("com/qmuiteam/qmui/link/QMUILinkify$TransformFilter", "", "Com.Qmuiteam.Qmui.Link.QMUILinkify/ITransformFilterInvoker")]
		public partial interface ITransformFilter : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='QMUILinkify.TransformFilter']/method[@name='transformUrl' and count(parameter)=2 and parameter[1][@type='java.util.regex.Matcher'] and parameter[2][@type='java.lang.String']]"
			[Register ("transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;", "GetTransformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_Handler:Com.Qmuiteam.Qmui.Link.QMUILinkify/ITransformFilterInvoker, QMUI.Droid")]
			string TransformUrl (global::Java.Util.Regex.Matcher match, string url);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/QMUILinkify$TransformFilter", DoNotGenerateAcw=true)]
		internal partial class ITransformFilterInvoker : global::Java.Lang.Object, ITransformFilter {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/QMUILinkify$TransformFilter", typeof (ITransformFilterInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ITransformFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITransformFilter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.link.QMUILinkify.TransformFilter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITransformFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetTransformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_Handler ()
			{
				if (cb_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_ == null)
					cb_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_TransformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_);
				return cb_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_;
			}

			static IntPtr n_TransformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_match, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.ITransformFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var match = global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Matcher> (native_match, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.TransformUrl (match, url));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_;
			public unsafe string TransformUrl (global::Java.Util.Regex.Matcher match, string url)
			{
				if (id_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_ == IntPtr.Zero)
					id_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_url = JNIEnv.NewString (url);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((match == null) ? IntPtr.Zero : ((global::Java.Lang.Object) match).Handle);
				__args [1] = new JValue (native_url);
				var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transformUrl_Ljava_util_regex_Matcher_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_url);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='QMUILinkify.WebUrlMatcher']"
		[Register ("com/qmuiteam/qmui/link/QMUILinkify$WebUrlMatcher", "", "Com.Qmuiteam.Qmui.Link.QMUILinkify/IWebUrlMatcherInvoker")]
		public partial interface IWebUrlMatcher : IJavaObject, IJavaPeerable {

			global::Java.Util.Regex.Pattern Pattern {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='QMUILinkify.WebUrlMatcher']/method[@name='getPattern' and count(parameter)=0]"
				[Register ("getPattern", "()Ljava/util/regex/Pattern;", "GetGetPatternHandler:Com.Qmuiteam.Qmui.Link.QMUILinkify/IWebUrlMatcherInvoker, QMUI.Droid")] get;
			}

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/QMUILinkify$WebUrlMatcher", DoNotGenerateAcw=true)]
		internal partial class IWebUrlMatcherInvoker : global::Java.Lang.Object, IWebUrlMatcher {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/QMUILinkify$WebUrlMatcher", typeof (IWebUrlMatcherInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IWebUrlMatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWebUrlMatcher> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.link.QMUILinkify.WebUrlMatcher"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWebUrlMatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getPattern;
#pragma warning disable 0169
			static Delegate GetGetPatternHandler ()
			{
				if (cb_getPattern == null)
					cb_getPattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPattern);
				return cb_getPattern;
			}

			static IntPtr n_GetPattern (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IWebUrlMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Pattern);
			}
#pragma warning restore 0169

			IntPtr id_getPattern;
			public unsafe global::Java.Util.Regex.Pattern Pattern {
				get {
					if (id_getPattern == IntPtr.Zero)
						id_getPattern = JNIEnv.GetMethodID (class_ref, "getPattern", "()Ljava/util/regex/Pattern;");
					return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPattern), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/QMUILinkify", typeof (QMUILinkify));
		internal static IntPtr class_ref {
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

		protected QMUILinkify (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/constructor[@name='QMUILinkify' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUILinkify ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='addLinks' and count(parameter)=5 and parameter[1][@type='android.text.Spannable'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.ColorStateList'] and parameter[4][@type='android.content.res.ColorStateList'] and parameter[5][@type='com.qmuiteam.qmui.span.QMUIOnSpanClickListener']]"
		[Register ("addLinks", "(Landroid/text/Spannable;ILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;Lcom/qmuiteam/qmui/span/QMUIOnSpanClickListener;)Z", "")]
		public static unsafe bool AddLinks (global::Android.Text.ISpannable text, int mask, global::Android.Content.Res.ColorStateList linkColor, global::Android.Content.Res.ColorStateList bgColor, global::Com.Qmuiteam.Qmui.Span.IQMUIOnSpanClickListener l)
		{
			const string __id = "addLinks.(Landroid/text/Spannable;ILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;Lcom/qmuiteam/qmui/span/QMUIOnSpanClickListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue (mask);
				__args [2] = new JniArgumentValue ((linkColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkColor).Handle);
				__args [3] = new JniArgumentValue ((bgColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bgColor).Handle);
				__args [4] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (linkColor);
				global::System.GC.KeepAlive (bgColor);
				global::System.GC.KeepAlive (l);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='addLinks' and count(parameter)=3 and parameter[1][@type='android.text.Spannable'] and parameter[2][@type='java.util.regex.Pattern'] and parameter[3][@type='java.lang.String']]"
		[Register ("addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z", "")]
		public static unsafe bool AddLinks (global::Android.Text.ISpannable text, global::Java.Util.Regex.Pattern pattern, string scheme)
		{
			const string __id = "addLinks.(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue ((pattern == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pattern).Handle);
				__args [2] = new JniArgumentValue (native_scheme);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (pattern);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='addLinks' and count(parameter)=5 and parameter[1][@type='android.text.Spannable'] and parameter[2][@type='java.util.regex.Pattern'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.qmuiteam.qmui.link.QMUILinkify.MatchFilter'] and parameter[5][@type='com.qmuiteam.qmui.link.QMUILinkify.TransformFilter']]"
		[Register ("addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Lcom/qmuiteam/qmui/link/QMUILinkify$MatchFilter;Lcom/qmuiteam/qmui/link/QMUILinkify$TransformFilter;)Z", "")]
		public static unsafe bool AddLinks (global::Android.Text.ISpannable s, global::Java.Util.Regex.Pattern p, string scheme, global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter matchFilter, global::Com.Qmuiteam.Qmui.Link.QMUILinkify.ITransformFilter transformFilter)
		{
			const string __id = "addLinks.(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Lcom/qmuiteam/qmui/link/QMUILinkify$MatchFilter;Lcom/qmuiteam/qmui/link/QMUILinkify$TransformFilter;)Z";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				__args [1] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [2] = new JniArgumentValue (native_scheme);
				__args [3] = new JniArgumentValue ((matchFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchFilter).Handle);
				__args [4] = new JniArgumentValue ((transformFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformFilter).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				global::System.GC.KeepAlive (s);
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (matchFilter);
				global::System.GC.KeepAlive (transformFilter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='addLinks' and count(parameter)=5 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.ColorStateList'] and parameter[4][@type='android.content.res.ColorStateList'] and parameter[5][@type='com.qmuiteam.qmui.span.QMUIOnSpanClickListener']]"
		[Register ("addLinks", "(Landroid/widget/TextView;ILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;Lcom/qmuiteam/qmui/span/QMUIOnSpanClickListener;)Z", "")]
		public static unsafe bool AddLinks (global::Android.Widget.TextView text, int mask, global::Android.Content.Res.ColorStateList linkColor, global::Android.Content.Res.ColorStateList bgColor, global::Com.Qmuiteam.Qmui.Span.IQMUIOnSpanClickListener l)
		{
			const string __id = "addLinks.(Landroid/widget/TextView;ILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;Lcom/qmuiteam/qmui/span/QMUIOnSpanClickListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue (mask);
				__args [2] = new JniArgumentValue ((linkColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkColor).Handle);
				__args [3] = new JniArgumentValue ((bgColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bgColor).Handle);
				__args [4] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (linkColor);
				global::System.GC.KeepAlive (bgColor);
				global::System.GC.KeepAlive (l);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='addLinks' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='java.util.regex.Pattern'] and parameter[3][@type='java.lang.String']]"
		[Register ("addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V", "")]
		public static unsafe void AddLinks (global::Android.Widget.TextView text, global::Java.Util.Regex.Pattern pattern, string scheme)
		{
			const string __id = "addLinks.(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue ((pattern == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pattern).Handle);
				__args [2] = new JniArgumentValue (native_scheme);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (pattern);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='addLinks' and count(parameter)=5 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='java.util.regex.Pattern'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.qmuiteam.qmui.link.QMUILinkify.MatchFilter'] and parameter[5][@type='com.qmuiteam.qmui.link.QMUILinkify.TransformFilter']]"
		[Register ("addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Lcom/qmuiteam/qmui/link/QMUILinkify$MatchFilter;Lcom/qmuiteam/qmui/link/QMUILinkify$TransformFilter;)V", "")]
		public static unsafe void AddLinks (global::Android.Widget.TextView text, global::Java.Util.Regex.Pattern p, string scheme, global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter matchFilter, global::Com.Qmuiteam.Qmui.Link.QMUILinkify.ITransformFilter transformFilter)
		{
			const string __id = "addLinks.(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Lcom/qmuiteam/qmui/link/QMUILinkify$MatchFilter;Lcom/qmuiteam/qmui/link/QMUILinkify$TransformFilter;)V";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [2] = new JniArgumentValue (native_scheme);
				__args [3] = new JniArgumentValue ((matchFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchFilter).Handle);
				__args [4] = new JniArgumentValue ((transformFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformFilter).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (matchFilter);
				global::System.GC.KeepAlive (transformFilter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='setWebUrlMatcher' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.link.QMUILinkify.WebUrlMatcher']]"
		[Register ("setWebUrlMatcher", "(Lcom/qmuiteam/qmui/link/QMUILinkify$WebUrlMatcher;)V", "")]
		public static unsafe void SetWebUrlMatcher (global::Com.Qmuiteam.Qmui.Link.QMUILinkify.IWebUrlMatcher webUrlMatcher)
		{
			const string __id = "setWebUrlMatcher.(Lcom/qmuiteam/qmui/link/QMUILinkify$WebUrlMatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webUrlMatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webUrlMatcher).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (webUrlMatcher);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkify']/method[@name='useQmuiWebUrlMatcher' and count(parameter)=0]"
		[Register ("useQmuiWebUrlMatcher", "()V", "")]
		public static unsafe void UseQmuiWebUrlMatcher ()
		{
			const string __id = "useQmuiWebUrlMatcher.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
	public static partial class QMUILinkifyIMatchFilterExtensions {

		public static bool AcceptMatch (this Com.Qmuiteam.Qmui.Link.QMUILinkify.IMatchFilter self, string s, int start, int end)
		{
			var jls_s = s == null ? null : new global::Java.Lang.String (s);
			bool __result = self.AcceptMatch (jls_s, start, end);
			var __rsval = __result;
			jls_s?.Dispose ();
			return __rsval;
		}
	}

}
