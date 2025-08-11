namespace Tsinswreng.CsPage;
using Tsinswreng.CsCore;


public partial class PageAsy{
	public PageAsy(){}

	public static IPageAsy<T> Mk<T>(
		IPageQry Qry
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new PageAsy<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			DataAsy = DataAsy,
			HasTotCnt = HasTotalCount,
		};
		return R;
	}
}


public partial class PageAsy<T>
	:I_TotCnt
	,IPageQry
	,IPageAsy<T>
{
	public PageAsy(){}

	public static IPageAsy<T> Mk(
		IPageQry Qry
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new PageAsy<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			DataAsy = DataAsy,
			HasTotCnt = HasTotalCount,
		};
		return R;
	}


	[Obsolete("直接new + 屬性初始化塊")]
	public static IPageAsy<T> Mk(
		IPageQry Qry
		,u64 TotalCount
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
	){
		var R = new PageAsy<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			DataAsy = DataAsy,
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
	public IAsyncEnumerable<T>? DataAsy{get;set;}

}



public static class ExtnPage{
	/// <summary>
	/// 因無擴展屬性、故于方法後加`_` 以期將來有擴展屬性語法旹不衝突
	/// </summary>
	/// <param name="z"></param>
	/// <returns></returns>
	public static u64 Offset_(
		this IPageInfo z
	){
		return z.PageIdx * z.PageSize;
	}
}
