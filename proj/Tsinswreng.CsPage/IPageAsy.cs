namespace Tsinswreng.CsPage;

/// <summary>
/// 分頁ʹ果
/// </summary>
/// <typeparam name="T"></typeparam>
public  partial interface IPageAsy<T>
	:I_TotCnt
	,IPageInfo
	,I_HasTotCnt
{
	public IAsyncEnumerable<T>? DataAsy{get;set;}

}
