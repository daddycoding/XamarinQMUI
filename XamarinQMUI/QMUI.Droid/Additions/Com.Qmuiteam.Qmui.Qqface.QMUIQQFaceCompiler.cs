using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Qqface {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler", DoNotGenerateAcw=true)]
	public partial class QMUIQQFaceCompiler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element", DoNotGenerateAcw=true)]
		public partial class Element : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element", typeof (Element));
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

			protected Element (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/constructor[@name='QMUIQQFaceCompiler.Element' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Element ()
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

			static Delegate cb_getChildList;
#pragma warning disable 0169
			static Delegate GetGetChildListHandler ()
			{
				if (cb_getChildList == null)
					cb_getChildList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChildList);
				return cb_getChildList;
			}

			static IntPtr n_GetChildList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ChildList);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList ChildList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='getChildList' and count(parameter)=0]"
				[Register ("getChildList", "()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList;", "GetGetChildListHandler")]
				get {
					const string __id = "getChildList.()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDrawableRes;
#pragma warning disable 0169
			static Delegate GetGetDrawableResHandler ()
			{
				if (cb_getDrawableRes == null)
					cb_getDrawableRes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDrawableRes);
				return cb_getDrawableRes;
			}

			static int n_GetDrawableRes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DrawableRes;
			}
#pragma warning restore 0169

			public virtual unsafe int DrawableRes {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='getDrawableRes' and count(parameter)=0]"
				[Register ("getDrawableRes", "()I", "GetGetDrawableResHandler")]
				get {
					const string __id = "getDrawableRes.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getSpecialBoundsDrawable;
#pragma warning disable 0169
			static Delegate GetGetSpecialBoundsDrawableHandler ()
			{
				if (cb_getSpecialBoundsDrawable == null)
					cb_getSpecialBoundsDrawable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSpecialBoundsDrawable);
				return cb_getSpecialBoundsDrawable;
			}

			static IntPtr n_GetSpecialBoundsDrawable (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SpecialBoundsDrawable);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Drawables.Drawable SpecialBoundsDrawable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='getSpecialBoundsDrawable' and count(parameter)=0]"
				[Register ("getSpecialBoundsDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetSpecialBoundsDrawableHandler")]
				get {
					const string __id = "getSpecialBoundsDrawable.()Landroid/graphics/drawable/Drawable;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.TextFormatted);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.ICharSequence TextFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
				get {
					const string __id = "getText.()Ljava/lang/CharSequence;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public string Text {
				get { return TextFormatted == null ? null : TextFormatted.ToString (); }
			}

			static Delegate cb_getTouchableSpan;
#pragma warning disable 0169
			static Delegate GetGetTouchableSpanHandler ()
			{
				if (cb_getTouchableSpan == null)
					cb_getTouchableSpan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTouchableSpan);
				return cb_getTouchableSpan;
			}

			static IntPtr n_GetTouchableSpan (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TouchableSpan);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan TouchableSpan {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='getTouchableSpan' and count(parameter)=0]"
				[Register ("getTouchableSpan", "()Lcom/qmuiteam/qmui/span/QMUITouchableSpan;", "GetGetTouchableSpanHandler")]
				get {
					const string __id = "getTouchableSpan.()Lcom/qmuiteam/qmui/span/QMUITouchableSpan;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Type);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='createDrawableElement' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("createDrawableElement", "(I)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateDrawableElement (int drawableRes)
			{
				const string __id = "createDrawableElement.(I)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (drawableRes);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='createNextLineElement' and count(parameter)=0]"
			[Register ("createNextLineElement", "()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateNextLineElement ()
			{
				const string __id = "createNextLineElement.()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='createSpeaicalBoundsDrawableElement' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("createSpeaicalBoundsDrawableElement", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateSpeaicalBoundsDrawableElement (global::Android.Graphics.Drawables.Drawable specialBoundsDrawable)
			{
				const string __id = "createSpeaicalBoundsDrawableElement.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((specialBoundsDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) specialBoundsDrawable).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (specialBoundsDrawable);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='createTextElement' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("createTextElement", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateTextElement (global::Java.Lang.ICharSequence text)
			{
				const string __id = "createTextElement.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
				}
			}

			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateTextElement (string text)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element __result = CreateTextElement (jls_text);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.Element']/method[@name='createTouchSpanElement' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='com.qmuiteam.qmui.span.QMUITouchableSpan'] and parameter[3][@type='com.qmuiteam.qmui.qqface.QMUIQQFaceCompiler']]"
			[Register ("createTouchSpanElement", "(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/span/QMUITouchableSpan;Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateTouchSpanElement (global::Java.Lang.ICharSequence text, global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan touchableSpan, global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler compiler)
			{
				const string __id = "createTouchSpanElement.(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/span/QMUITouchableSpan;Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_text);
					__args [1] = new JniArgumentValue ((touchableSpan == null) ? IntPtr.Zero : ((global::Java.Lang.Object) touchableSpan).Handle);
					__args [2] = new JniArgumentValue ((compiler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compiler).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
					global::System.GC.KeepAlive (touchableSpan);
					global::System.GC.KeepAlive (compiler);
				}
			}

			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element CreateTouchSpanElement (string text, global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan touchableSpan, global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler compiler)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element __result = CreateTouchSpanElement (jls_text, touchableSpan, compiler);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList", DoNotGenerateAcw=true)]
		public partial class ElementList : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList", typeof (ElementList));
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

			protected ElementList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/constructor[@name='QMUIQQFaceCompiler.ElementList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe ElementList (int start, int end)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (start);
					__args [1] = new JniArgumentValue (end);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getElements;
#pragma warning disable 0169
			static Delegate GetGetElementsHandler ()
			{
				if (cb_getElements == null)
					cb_getElements = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetElements);
				return cb_getElements;
			}

			static IntPtr n_GetElements (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element>.ToLocalJniHandle (__this.Elements);
			}
#pragma warning restore 0169

			public virtual unsafe global::System.Collections.Generic.IList<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> Elements {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/method[@name='getElements' and count(parameter)=0]"
				[Register ("getElements", "()Ljava/util/List;", "GetGetElementsHandler")]
				get {
					const string __id = "getElements.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getEnd;
#pragma warning disable 0169
			static Delegate GetGetEndHandler ()
			{
				if (cb_getEnd == null)
					cb_getEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEnd);
				return cb_getEnd;
			}

			static int n_GetEnd (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.End;
			}
#pragma warning restore 0169

			public virtual unsafe int End {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/method[@name='getEnd' and count(parameter)=0]"
				[Register ("getEnd", "()I", "GetGetEndHandler")]
				get {
					const string __id = "getEnd.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getNewLineCount;
#pragma warning disable 0169
			static Delegate GetGetNewLineCountHandler ()
			{
				if (cb_getNewLineCount == null)
					cb_getNewLineCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNewLineCount);
				return cb_getNewLineCount;
			}

			static int n_GetNewLineCount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NewLineCount;
			}
#pragma warning restore 0169

			public virtual unsafe int NewLineCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/method[@name='getNewLineCount' and count(parameter)=0]"
				[Register ("getNewLineCount", "()I", "GetGetNewLineCountHandler")]
				get {
					const string __id = "getNewLineCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getQQFaceCount;
#pragma warning disable 0169
			static Delegate GetGetQQFaceCountHandler ()
			{
				if (cb_getQQFaceCount == null)
					cb_getQQFaceCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetQQFaceCount);
				return cb_getQQFaceCount;
			}

			static int n_GetQQFaceCount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.QQFaceCount;
			}
#pragma warning restore 0169

			public virtual unsafe int QQFaceCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/method[@name='getQQFaceCount' and count(parameter)=0]"
				[Register ("getQQFaceCount", "()I", "GetGetQQFaceCountHandler")]
				get {
					const string __id = "getQQFaceCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getStart;
#pragma warning disable 0169
			static Delegate GetGetStartHandler ()
			{
				if (cb_getStart == null)
					cb_getStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStart);
				return cb_getStart;
			}

			static int n_GetStart (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Start;
			}
#pragma warning restore 0169

			public virtual unsafe int Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()I", "GetGetStartHandler")]
				get {
					const string __id = "getStart.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_add_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_;
#pragma warning disable 0169
			static Delegate GetAdd_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_Handler ()
			{
				if (cb_add_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_ == null)
					cb_add_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_);
				return cb_add_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_;
			}

			static void n_Add_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_ (IntPtr jnienv, IntPtr native__this, IntPtr native_element)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var element = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element> (native_element, JniHandleOwnership.DoNotTransfer);
				__this.Add (element);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.qqface.QMUIQQFaceCompiler.Element']]"
			[Register ("add", "(Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;)V", "GetAdd_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Element_Handler")]
			public virtual unsafe void Add (global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.Element element)
			{
				const string __id = "add.(Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$Element;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((element == null) ? IntPtr.Zero : ((global::Java.Lang.Object) element).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (element);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType", DoNotGenerateAcw=true)]
		public sealed partial class ElementType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/field[@name='DRAWABLE']"
			[Register ("DRAWABLE")]
			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType Drawable {
				get {
					const string __id = "DRAWABLE.Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/field[@name='NEXTLINE']"
			[Register ("NEXTLINE")]
			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType Nextline {
				get {
					const string __id = "NEXTLINE.Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/field[@name='SPAN']"
			[Register ("SPAN")]
			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType Span {
				get {
					const string __id = "SPAN.Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/field[@name='SPECIAL_BOUNDS_DRAWABLE']"
			[Register ("SPECIAL_BOUNDS_DRAWABLE")]
			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType SpecialBoundsDrawable {
				get {
					const string __id = "SPECIAL_BOUNDS_DRAWABLE.Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType Text {
				get {
					const string __id = "TEXT.Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType", typeof (ElementType));
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

			internal ElementType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler.ElementType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType[] Values ()
			{
				const string __id = "values.()[Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceCompiler", typeof (QMUIQQFaceCompiler));
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

		protected QMUIQQFaceCompiler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler DefaultInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='getDefaultInstance' and count(parameter)=0]"
			[Register ("getDefaultInstance", "()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;", "")]
			get {
				const string __id = "getDefaultInstance.()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSpecialBoundsMaxHeight;
#pragma warning disable 0169
		static Delegate GetGetSpecialBoundsMaxHeightHandler ()
		{
			if (cb_getSpecialBoundsMaxHeight == null)
				cb_getSpecialBoundsMaxHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSpecialBoundsMaxHeight);
			return cb_getSpecialBoundsMaxHeight;
		}

		static int n_GetSpecialBoundsMaxHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpecialBoundsMaxHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int SpecialBoundsMaxHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='getSpecialBoundsMaxHeight' and count(parameter)=0]"
			[Register ("getSpecialBoundsMaxHeight", "()I", "GetGetSpecialBoundsMaxHeightHandler")]
			get {
				const string __id = "getSpecialBoundsMaxHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_compile_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetCompile_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_compile_Ljava_lang_CharSequence_ == null)
				cb_compile_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Compile_Ljava_lang_CharSequence_);
			return cb_compile_Ljava_lang_CharSequence_;
		}

		static IntPtr n_Compile_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compile (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='compile' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("compile", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList;", "GetCompile_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList Compile (global::Java.Lang.ICharSequence text)
		{
			const string __id = "compile.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
			}
		}

		public global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList Compile (string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList __result = Compile (jls_text);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}

		static Delegate cb_compile_Ljava_lang_CharSequence_II;
#pragma warning disable 0169
		static Delegate GetCompile_Ljava_lang_CharSequence_IIHandler ()
		{
			if (cb_compile_Ljava_lang_CharSequence_II == null)
				cb_compile_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Compile_Ljava_lang_CharSequence_II);
			return cb_compile_Ljava_lang_CharSequence_II;
		}

		static IntPtr n_Compile_Ljava_lang_CharSequence_II (IntPtr jnienv, IntPtr native__this, IntPtr native_text, int start, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compile (text, start, end));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='compile' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("compile", "(Ljava/lang/CharSequence;II)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList;", "GetCompile_Ljava_lang_CharSequence_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList Compile (global::Java.Lang.ICharSequence text, int start, int end)
		{
			const string __id = "compile.(Ljava/lang/CharSequence;II)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler$ElementList;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
			}
		}

		public global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList Compile (string text, int start, int end)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler.ElementList __result = Compile (jls_text, start, end);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.qqface.IQMUIQQFaceManager']]"
		[Register ("getInstance", "(Lcom/qmuiteam/qmui/qqface/IQMUIQQFaceManager;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler GetInstance (global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager manager)
		{
			const string __id = "getInstance.(Lcom/qmuiteam/qmui/qqface/IQMUIQQFaceManager;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (manager);
			}
		}

		static Delegate cb_setCache_Landroid_util_LruCache_;
#pragma warning disable 0169
		static Delegate GetSetCache_Landroid_util_LruCache_Handler ()
		{
			if (cb_setCache_Landroid_util_LruCache_ == null)
				cb_setCache_Landroid_util_LruCache_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCache_Landroid_util_LruCache_);
			return cb_setCache_Landroid_util_LruCache_;
		}

		static void n_SetCache_Landroid_util_LruCache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cache)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cache = global::Java.Lang.Object.GetObject<global::Android.Util.LruCache> (native_cache, JniHandleOwnership.DoNotTransfer);
			__this.SetCache (cache);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='setCache' and count(parameter)=1 and parameter[1][@type='android.util.LruCache&lt;java.lang.CharSequence, com.qmuiteam.qmui.qqface.QMUIQQFaceCompiler.ElementList&gt;']]"
		[Register ("setCache", "(Landroid/util/LruCache;)V", "GetSetCache_Landroid_util_LruCache_Handler")]
		public virtual unsafe void SetCache (global::Android.Util.LruCache cache)
		{
			const string __id = "setCache.(Landroid/util/LruCache;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cache).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cache);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceCompiler']/method[@name='setDefaultQQFaceManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.qqface.IQMUIQQFaceManager']]"
		[Register ("setDefaultQQFaceManager", "(Lcom/qmuiteam/qmui/qqface/IQMUIQQFaceManager;)V", "")]
		public static unsafe void SetDefaultQQFaceManager (global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager defaultQQFaceManager)
		{
			const string __id = "setDefaultQQFaceManager.(Lcom/qmuiteam/qmui/qqface/IQMUIQQFaceManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultQQFaceManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultQQFaceManager).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (defaultQQFaceManager);
			}
		}

	}
}
