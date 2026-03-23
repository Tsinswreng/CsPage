using Tsinswreng.CsCore;

namespace Tsinswreng.CsPage;

public partial class PageQry
	:IPageQry
{
	
	/// from 0
	
	public u64 PageIdx{get;set;}
	public u64 PageSize{get;set;}
	public bool WantTotCnt{get;set;}
	
	public static IPageQry SlctI64Max(){
		var R = new PageQry();
		R.PageIdx = 0;
/// Npgsql不支持Uint64。宜移SlctAll方法 至 ITable上。
		R.PageSize = i64.MaxValue;
		R.WantTotCnt = true;
		return R;
	}
}

public static class ExtnPageQry{
	extension(IPageQry z){
		
		[Doc(@$"To Page Result")]
		public IPageAsyE<T> ToPageAsyE<T>(
			IAsyncEnumerable<T> DataAsyE
			,bool HasTotCnt = false
			,u64 TotCnt = 0
		){
			return PageAsyE.Mk<T>(
				z, DataAsyE, HasTotCnt, TotCnt
			);
		}
	}
}