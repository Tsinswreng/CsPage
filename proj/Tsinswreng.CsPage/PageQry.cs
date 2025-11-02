namespace Tsinswreng.CsPage;

public partial class PageQry
	:IPageQry
{
	/// <summary>
	/// from 0
	/// </summary>
	public u64 PageIdx{get;set;}
	public u64 PageSize{get;set;}
	public bool WantTotCnt{get;set;}
	[Obsolete]
	public static IPageQry SlctAll(){
		var R = new PageQry();
		R.PageIdx = 0;
/// Npgsql不支持Uint64。宜移SlctAll方法 至 ITable上。
		R.PageSize = i64.MaxValue;
		R.WantTotCnt = true;
		return R;
	}
}
