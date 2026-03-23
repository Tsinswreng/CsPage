using Tsinswreng.CsCore;

namespace Tsinswreng.CsPage;


[Doc(@$"Page Result")]
public partial interface IPageAsyE<T>
	:I_TotCnt
	,IPageInfo
	,I_HasTotCnt
{
	public IAsyncEnumerable<T>? DataAsyE{get;set;}

}
