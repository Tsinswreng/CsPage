namespace Tsinswreng.CsPage;

public  partial class PageQuery
	:IPageQuery
{
	/// <summary>
	/// from 0
	/// </summary>
	public u64 PageIndex{get;set;}
	public u64 PageSize{get;set;}
	public bool WantTotalCount{get;set;}
	public static IPageQuery SelectAll(){
		var R = new PageQuery();
		R.PageIndex = 0;
		R.PageSize = u64.MaxValue;
		R.WantTotalCount = true;
		return R;
	}
}
