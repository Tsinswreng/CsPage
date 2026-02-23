namespace Tsinswreng.CsPage;


/// 分頁ʹ果
public partial interface IPageAsyE<T>
	:I_TotCnt
	,IPageInfo
	,I_HasTotCnt
{
	public IAsyncEnumerable<T>? DataAsyE{get;set;}

}
