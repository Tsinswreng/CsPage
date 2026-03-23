namespace Tsinswreng.CsPage;

/// 分頁ʹ果
public partial interface IPage<T>
	:I_TotCnt
	,IPageInfo
	,I_HasTotCnt
{
	public IList<T>? Data{get;set;}
}
