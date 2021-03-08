using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUICollapsingTextHelper", DoNotGenerateAcw=true)]
	public sealed partial class QMUICollapsingTextHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUICollapsingTextHelper", typeof (QMUICollapsingTextHelper));
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

		internal QMUICollapsingTextHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/constructor[@name='QMUICollapsingTextHelper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe QMUICollapsingTextHelper (global::Android.Views.View view)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/constructor[@name='QMUICollapsingTextHelper' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register (".ctor", "(Landroid/view/View;F)V", "")]
		public unsafe QMUICollapsingTextHelper (global::Android.Views.View view, float defaultExpanededFraction)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (defaultExpanededFraction);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		public unsafe float CollapsedDrawX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getCollapsedDrawX' and count(parameter)=0]"
			[Register ("getCollapsedDrawX", "()F", "")]
			get {
				const string __id = "getCollapsedDrawX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int CollapsedTextGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getCollapsedTextGravity' and count(parameter)=0]"
			[Register ("getCollapsedTextGravity", "()I", "")]
			get {
				const string __id = "getCollapsedTextGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setCollapsedTextGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCollapsedTextGravity", "(I)V", "")]
			set {
				const string __id = "setCollapsedTextGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float CollapsedTextHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getCollapsedTextHeight' and count(parameter)=0]"
			[Register ("getCollapsedTextHeight", "()F", "")]
			get {
				const string __id = "getCollapsedTextHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float CollapsedTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getCollapsedTextSize' and count(parameter)=0]"
			[Register ("getCollapsedTextSize", "()F", "")]
			get {
				const string __id = "getCollapsedTextSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setCollapsedTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCollapsedTextSize", "(F)V", "")]
			set {
				const string __id = "setCollapsedTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float CollapsedTextWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getCollapsedTextWidth' and count(parameter)=0]"
			[Register ("getCollapsedTextWidth", "()F", "")]
			get {
				const string __id = "getCollapsedTextWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Typeface CollapsedTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getCollapsedTypeface' and count(parameter)=0]"
			[Register ("getCollapsedTypeface", "()Landroid/graphics/Typeface;", "")]
			get {
				const string __id = "getCollapsedTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setCollapsedTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setCollapsedTypeface", "(Landroid/graphics/Typeface;)V", "")]
			set {
				const string __id = "setCollapsedTypeface.(Landroid/graphics/Typeface;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe float ExpandedDrawX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpandedDrawX' and count(parameter)=0]"
			[Register ("getExpandedDrawX", "()F", "")]
			get {
				const string __id = "getExpandedDrawX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ExpandedTextGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpandedTextGravity' and count(parameter)=0]"
			[Register ("getExpandedTextGravity", "()I", "")]
			get {
				const string __id = "getExpandedTextGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpandedTextGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpandedTextGravity", "(I)V", "")]
			set {
				const string __id = "setExpandedTextGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float ExpandedTextHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpandedTextHeight' and count(parameter)=0]"
			[Register ("getExpandedTextHeight", "()F", "")]
			get {
				const string __id = "getExpandedTextHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float ExpandedTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpandedTextSize' and count(parameter)=0]"
			[Register ("getExpandedTextSize", "()F", "")]
			get {
				const string __id = "getExpandedTextSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpandedTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExpandedTextSize", "(F)V", "")]
			set {
				const string __id = "setExpandedTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float ExpandedTextWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpandedTextWidth' and count(parameter)=0]"
			[Register ("getExpandedTextWidth", "()F", "")]
			get {
				const string __id = "getExpandedTextWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Typeface ExpandedTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpandedTypeface' and count(parameter)=0]"
			[Register ("getExpandedTypeface", "()Landroid/graphics/Typeface;", "")]
			get {
				const string __id = "getExpandedTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpandedTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setExpandedTypeface", "(Landroid/graphics/Typeface;)V", "")]
			set {
				const string __id = "setExpandedTypeface.(Landroid/graphics/Typeface;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe float ExpansionFraction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getExpansionFraction' and count(parameter)=0]"
			[Register ("getExpansionFraction", "()F", "")]
			get {
				const string __id = "getExpansionFraction.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpansionFraction' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExpansionFraction", "(F)V", "")]
			set {
				const string __id = "setExpansionFraction.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IsStateful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='isStateful' and count(parameter)=0]"
			[Register ("isStateful", "()Z", "")]
			get {
				const string __id = "isStateful.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.ICharSequence TextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/CharSequence;", "")]
			get {
				const string __id = "getText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setText", "(Ljava/lang/CharSequence;)V", "")]
			set {
				const string __id = "setText.(Ljava/lang/CharSequence;)V";
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public string Text {
			get { return TextFormatted == null ? null : TextFormatted.ToString (); }
			set {
				var jls = value == null ? null : new global::Java.Lang.String (value);
				TextFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='calculateBaseOffsets' and count(parameter)=0]"
		[Register ("calculateBaseOffsets", "()V", "")]
		public unsafe void CalculateBaseOffsets ()
		{
			const string __id = "calculateBaseOffsets.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='calculateCurrentOffsets' and count(parameter)=0]"
		[Register ("calculateCurrentOffsets", "()V", "")]
		public unsafe void CalculateCurrentOffsets ()
		{
			const string __id = "calculateCurrentOffsets.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "")]
		public unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='lerp' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='android.view.animation.Interpolator']]"
		[Register ("lerp", "(FFFLandroid/view/animation/Interpolator;)F", "")]
		public static unsafe float Lerp (float startValue, float endValue, float fraction, global::Android.Views.Animations.IInterpolator interpolator)
		{
			const string __id = "lerp.(FFFLandroid/view/animation/Interpolator;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (startValue);
				__args [1] = new JniArgumentValue (endValue);
				__args [2] = new JniArgumentValue (fraction);
				__args [3] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interpolator);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='recalculate' and count(parameter)=0]"
		[Register ("recalculate", "()V", "")]
		public unsafe void Recalculate ()
		{
			const string __id = "recalculate.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setCollapsedBounds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setCollapsedBounds", "(IIII)V", "")]
		public unsafe void SetCollapsedBounds (int left, int top, int right, int bottom)
		{
			const string __id = "setCollapsedBounds.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setCollapsedTextAppearance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCollapsedTextAppearance", "(I)V", "")]
		public unsafe void SetCollapsedTextAppearance (int resId)
		{
			const string __id = "setCollapsedTextAppearance.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setCollapsedTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setCollapsedTextColor", "(Landroid/content/res/ColorStateList;)V", "")]
		public unsafe void SetCollapsedTextColor (global::Android.Content.Res.ColorStateList textColor)
		{
			const string __id = "setCollapsedTextColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textColor).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (textColor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpandedBounds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setExpandedBounds", "(IIII)V", "")]
		public unsafe void SetExpandedBounds (int left, int top, int right, int bottom)
		{
			const string __id = "setExpandedBounds.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpandedTextAppearance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExpandedTextAppearance", "(I)V", "")]
		public unsafe void SetExpandedTextAppearance (int resId)
		{
			const string __id = "setExpandedTextAppearance.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setExpandedTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setExpandedTextColor", "(Landroid/content/res/ColorStateList;)V", "")]
		public unsafe void SetExpandedTextColor (global::Android.Content.Res.ColorStateList textColor)
		{
			const string __id = "setExpandedTextColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textColor).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (textColor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setGravity' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("setGravity", "(IIZ)V", "")]
		public unsafe void SetGravity (int collapsedGravity, int expandedGravity, bool recalculate)
		{
			const string __id = "setGravity.(IIZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (collapsedGravity);
				__args [1] = new JniArgumentValue (expandedGravity);
				__args [2] = new JniArgumentValue (recalculate);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setPositionInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setPositionInterpolator", "(Landroid/view/animation/Interpolator;)V", "")]
		public unsafe void SetPositionInterpolator (global::Android.Views.Animations.IInterpolator interpolator)
		{
			const string __id = "setPositionInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (interpolator);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setState", "([I)Z", "")]
		public unsafe bool SetState (int[] state)
		{
			const string __id = "setState.([I)Z";
			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_state);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
				global::System.GC.KeepAlive (state);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setTextColor' and count(parameter)=3 and parameter[1][@type='android.content.res.ColorStateList'] and parameter[2][@type='android.content.res.ColorStateList'] and parameter[3][@type='boolean']]"
		[Register ("setTextColor", "(Landroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;Z)V", "")]
		public unsafe void SetTextColor (global::Android.Content.Res.ColorStateList collapsedTextColor, global::Android.Content.Res.ColorStateList expandedTextColor, bool recalculate)
		{
			const string __id = "setTextColor.(Landroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((collapsedTextColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collapsedTextColor).Handle);
				__args [1] = new JniArgumentValue ((expandedTextColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expandedTextColor).Handle);
				__args [2] = new JniArgumentValue (recalculate);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (collapsedTextColor);
				global::System.GC.KeepAlive (expandedTextColor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setTextSize' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("setTextSize", "(FFZ)V", "")]
		public unsafe void SetTextSize (float collapsedTextSize, float expandedTextSize, bool recalculate)
		{
			const string __id = "setTextSize.(FFZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (collapsedTextSize);
				__args [1] = new JniArgumentValue (expandedTextSize);
				__args [2] = new JniArgumentValue (recalculate);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setTextSizeInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setTextSizeInterpolator", "(Landroid/view/animation/Interpolator;)V", "")]
		public unsafe void SetTextSizeInterpolator (global::Android.Views.Animations.IInterpolator interpolator)
		{
			const string __id = "setTextSizeInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (interpolator);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setTypeface' and count(parameter)=3 and parameter[1][@type='android.graphics.Typeface'] and parameter[2][@type='android.graphics.Typeface'] and parameter[3][@type='boolean']]"
		[Register ("setTypeface", "(Landroid/graphics/Typeface;Landroid/graphics/Typeface;Z)V", "")]
		public unsafe void SetTypeface (global::Android.Graphics.Typeface collapsedTypeface, global::Android.Graphics.Typeface expandedTypeface, bool recalculate)
		{
			const string __id = "setTypeface.(Landroid/graphics/Typeface;Landroid/graphics/Typeface;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((collapsedTypeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collapsedTypeface).Handle);
				__args [1] = new JniArgumentValue ((expandedTypeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expandedTypeface).Handle);
				__args [2] = new JniArgumentValue (recalculate);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (collapsedTypeface);
				global::System.GC.KeepAlive (expandedTypeface);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setTypefaceUpdateAreaPercent' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTypefaceUpdateAreaPercent", "(F)V", "")]
		public unsafe void SetTypefaceUpdateAreaPercent (float typefaceUpdateAreaPercent)
		{
			const string __id = "setTypefaceUpdateAreaPercent.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (typefaceUpdateAreaPercent);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUICollapsingTextHelper']/method[@name='setTypefaces' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setTypefaces", "(Landroid/graphics/Typeface;)V", "")]
		public unsafe void SetTypefaces (global::Android.Graphics.Typeface typeface)
		{
			const string __id = "setTypefaces.(Landroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (typeface);
			}
		}

	}
}
