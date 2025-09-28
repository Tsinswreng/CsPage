namespace Tsinswreng.CsPage;
using Tsinswreng.CsCore;

public partial class Page{
	public Page(){}

	public static IPage<T> Mk<T>(
		IPageQry Qry
		,IList<T>? Data
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new Page<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			Data = Data,
			HasTotCnt = HasTotalCount,
		};
		return R;
	}
}


public partial class Page<T>
	:I_TotCnt
	,IPageQry
	,IPage<T>
{

	public Page(){}

	public static IPage<T> Mk(
		IPageQry Qry
		,IList<T>? Data
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new Page<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			Data = Data,
			HasTotCnt = HasTotalCount,
		};
		return R;
	}

	public IPageQry PageQry{
		get{
			return new PageQry{
				PageIdx = this.PageIdx
				,PageSize = this.PageSize
				,WantTotCnt = this.WantTotCnt
			};
		}
		set{
			PageIdx = value.PageIdx;
			PageSize = value.PageSize;
			WantTotCnt = value.WantTotCnt;
		}
	}

	[Impl]
	public bool WantTotCnt{get;set;}
	[Impl]
	public bool HasTotCnt{get;set;}
	[Impl]
	public u64 TotCnt{get;set;}
	[Impl]
	public u64 PageIdx{get;set;}
	[Impl]
	public u64 PageSize{get;set;}

	[Impl]
	public IList<T>? Data{get;set;}


}



