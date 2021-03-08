using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui", Managed="Com.Qmuiteam.Qmui")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.alpha", Managed="Com.Qmuiteam.Qmui.Alpha")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.kotlin", Managed="Com.Qmuiteam.Qmui.Kotlin")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.layout", Managed="Com.Qmuiteam.Qmui.Layout")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.link", Managed="Com.Qmuiteam.Qmui.Link")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.nestedScroll", Managed="Com.Qmuiteam.Qmui.NestedScroll")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.qqface", Managed="Com.Qmuiteam.Qmui.Qqface")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.recyclerView", Managed="Com.Qmuiteam.Qmui.RecyclerView")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.skin", Managed="Com.Qmuiteam.Qmui.Skin")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.skin.annotation", Managed="Com.Qmuiteam.Qmui.Skin.Annotation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.skin.defaultAttr", Managed="Com.Qmuiteam.Qmui.Skin.DefaultAttr")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.skin.handler", Managed="Com.Qmuiteam.Qmui.Skin.Handler")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.span", Managed="Com.Qmuiteam.Qmui.Span")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.util", Managed="Com.Qmuiteam.Qmui.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget", Managed="Com.Qmuiteam.Qmui.Widget")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.dialog", Managed="Com.Qmuiteam.Qmui.Widget.Dialog")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.grouplist", Managed="Com.Qmuiteam.Qmui.Widget.Grouplist")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.popup", Managed="Com.Qmuiteam.Qmui.Widget.Popup")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.pullLayout", Managed="Com.Qmuiteam.Qmui.Widget.PullLayout")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.pullRefreshLayout", Managed="Com.Qmuiteam.Qmui.Widget.PullRefreshLayout")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.roundwidget", Managed="Com.Qmuiteam.Qmui.Widget.Roundwidget")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.section", Managed="Com.Qmuiteam.Qmui.Widget.Section")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.tab", Managed="Com.Qmuiteam.Qmui.Widget.Tab")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.textview", Managed="Com.Qmuiteam.Qmui.Widget.Textview")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.qmuiteam.qmui.widget.webview", Managed="Com.Qmuiteam.Qmui.Widget.Webview")]

delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PPC_I (IntPtr jnienv, IntPtr klass, char p0);
delegate bool _JniMarshal_PPC_Z (IntPtr jnienv, IntPtr klass, char p0);
delegate float _JniMarshal_PPF_F (IntPtr jnienv, IntPtr klass, float p0);
delegate int _JniMarshal_PPF_I (IntPtr jnienv, IntPtr klass, float p0);
delegate IntPtr _JniMarshal_PPF_L (IntPtr jnienv, IntPtr klass, float p0);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate void _JniMarshal_PPFF_V (IntPtr jnienv, IntPtr klass, float p0, float p1);
delegate bool _JniMarshal_PPFF_Z (IntPtr jnienv, IntPtr klass, float p0, float p1);
delegate void _JniMarshal_PPFI_V (IntPtr jnienv, IntPtr klass, float p0, int p1);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPIF_L (IntPtr jnienv, IntPtr klass, int p0, float p1);
delegate void _JniMarshal_PPIF_V (IntPtr jnienv, IntPtr klass, int p0, float p1);
delegate void _JniMarshal_PPIFI_V (IntPtr jnienv, IntPtr klass, int p0, float p1, int p2);
delegate int _JniMarshal_PPII_I (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate IntPtr _JniMarshal_PPII_L (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate bool _JniMarshal_PPII_Z (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPIIF_V (IntPtr jnienv, IntPtr klass, int p0, int p1, float p2);
delegate int _JniMarshal_PPIII_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPIII_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate void _JniMarshal_PPIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate void _JniMarshal_PPIIIF_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, float p3);
delegate IntPtr _JniMarshal_PPIIII_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIIIF_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, float p4);
delegate int _JniMarshal_PPIIIIII_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, int p4, int p5);
delegate void _JniMarshal_PPIIIIIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, int p4, int p5, int p6);
delegate bool _JniMarshal_PPIIIILI_Z (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, IntPtr p4, int p5);
delegate IntPtr _JniMarshal_PPIIIL_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, IntPtr p3);
delegate int _JniMarshal_PPIIIZ_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, bool p3);
delegate IntPtr _JniMarshal_PPIIL_L (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate bool _JniMarshal_PPIILLI_Z (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2, IntPtr p3, int p4);
delegate int _JniMarshal_PPIIZ_I (IntPtr jnienv, IntPtr klass, int p0, int p1, bool p2);
delegate IntPtr _JniMarshal_PPIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate bool _JniMarshal_PPIL_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPILI_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPILIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, int p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPILL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPILLI_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3);
delegate IntPtr _JniMarshal_PPILLII_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3, int p4);
delegate IntPtr _JniMarshal_PPILLIIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3, int p4, IntPtr p5);
delegate IntPtr _JniMarshal_PPILLZ_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, bool p3);
delegate IntPtr _JniMarshal_PPILLZZ_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, bool p3, bool p4);
delegate void _JniMarshal_PPIZ_V (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate IntPtr _JniMarshal_PPIZI_L (IntPtr jnienv, IntPtr klass, int p0, bool p1, int p2);
delegate IntPtr _JniMarshal_PPIZIII_L (IntPtr jnienv, IntPtr klass, int p0, bool p1, int p2, int p3, int p4);
delegate void _JniMarshal_PPIZZ_V (IntPtr jnienv, IntPtr klass, int p0, bool p1, bool p2);
delegate int _JniMarshal_PPJ_I (IntPtr jnienv, IntPtr klass, long p0);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate void _JniMarshal_PPJZ_V (IntPtr jnienv, IntPtr klass, long p0, bool p1);
delegate float _JniMarshal_PPL_F (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPLFF_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1, float p2);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate bool _JniMarshal_PPLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLIF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, float p2);
delegate long _JniMarshal_PPLIFF_J (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, float p2, float p3);
delegate IntPtr _JniMarshal_PPLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate bool _JniMarshal_PPLII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3);
delegate IntPtr _JniMarshal_PPLIIII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4);
delegate void _JniMarshal_PPLIIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4);
delegate void _JniMarshal_PPLIIIIFLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4, float p5, IntPtr p6, int p7, int p8);
delegate int _JniMarshal_PPLIIIII_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4, int p5);
delegate void _JniMarshal_PPLIIIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4, int p5);
delegate void _JniMarshal_PPLIIIIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4, int p5, int p6);
delegate void _JniMarshal_PPLIIIIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4, int p5, IntPtr p6);
delegate IntPtr _JniMarshal_PPLIIJ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, long p3);
delegate void _JniMarshal_PPLIILI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3, int p4);
delegate void _JniMarshal_PPLIIZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, bool p3);
delegate void _JniMarshal_PPLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPLILI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3);
delegate bool _JniMarshal_PPLILI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3);
delegate void _JniMarshal_PPLILL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLILZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, bool p3);
delegate void _JniMarshal_PPLIZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, bool p2);
delegate int _JniMarshal_PPLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, float p2);
delegate bool _JniMarshal_PPLLFFI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, float p2, float p3, int p4);
delegate void _JniMarshal_PPLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate bool _JniMarshal_PPLLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate void _JniMarshal_PPLLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3);
delegate bool _JniMarshal_PPLLII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3);
delegate void _JniMarshal_PPLLIIFIIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, float p4, int p5, int p6, int p7, IntPtr p8);
delegate int _JniMarshal_PPLLIIL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, IntPtr p4);
delegate void _JniMarshal_PPLLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, IntPtr p3);
delegate void _JniMarshal_PPLLILZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, IntPtr p3, bool p4);
delegate void _JniMarshal_PPLLJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, long p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLFFZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, float p3, float p4, bool p5);
delegate void _JniMarshal_PPLLLFFZI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, float p3, float p4, bool p5, int p6);
delegate IntPtr _JniMarshal_PPLLLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3, int p4);
delegate IntPtr _JniMarshal_PPLLLIII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3, int p4, int p5);
delegate IntPtr _JniMarshal_PPLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, int p4);
delegate bool _JniMarshal_PPLLLLII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, int p4, int p5);
delegate void _JniMarshal_PPLLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
delegate void _JniMarshal_PPLLZZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2, bool p3);
delegate int _JniMarshal_PPLZ_I (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPLZII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, int p2, int p3);
delegate IntPtr _JniMarshal_PPLZJZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, long p2, bool p3);
delegate void _JniMarshal_PPLZZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate IntPtr _JniMarshal_PPZI_L (IntPtr jnienv, IntPtr klass, bool p0, int p1);
delegate bool _JniMarshal_PPZI_Z (IntPtr jnienv, IntPtr klass, bool p0, int p1);
delegate void _JniMarshal_PPZIIII_V (IntPtr jnienv, IntPtr klass, bool p0, int p1, int p2, int p3, int p4);
delegate IntPtr _JniMarshal_PPZIZZ_L (IntPtr jnienv, IntPtr klass, bool p0, int p1, bool p2, bool p3);
delegate void _JniMarshal_PPZLLLL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPZZ_V (IntPtr jnienv, IntPtr klass, bool p0, bool p1);
