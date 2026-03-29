using Tsinswreng.CsCore;

namespace Tsinswreng.CsPage;
public partial interface I_TotCnt{
	[Doc(@$"Total count of items (not count of pages)")]
	public u64 TotCnt{get;set;}
}

