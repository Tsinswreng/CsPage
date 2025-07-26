namespace Tsinswreng.CsPage;

/// <summary>
/// 分頁ʹ果
/// </summary>
/// <typeparam name="T"></typeparam>
public  partial interface IPageAsy<T>
	:I_TotalCount
	,IPageInfo
	,I_HasTotalCount
{
	public IAsyncEnumerable<T>? DataAsy{get;set;}

}
