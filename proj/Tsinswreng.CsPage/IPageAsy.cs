namespace Tsinswreng.CsPage;


public interface IPageAsy<T>
	:I_TotalCount
	,IPageInfo
	,I_HasTotalCount
{
	public IAsyncEnumerable<T>? DataAsy{get;set;}
}
