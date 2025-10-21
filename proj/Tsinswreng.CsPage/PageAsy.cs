namespace Tsinswreng.CsPage;
using Tsinswreng.CsCore;

//[Obsolete("分頁旹應把每頁內容全載入內存洏非懶加載")]

public partial class PageAsyE{
	public PageAsyE(){}

	public static IPageAsyE<T> Mk<T>(
		IPageQry Qry
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new PageAsyE<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			DataAsyE = DataAsy,
			HasTotCnt = HasTotalCount,
		};
		return R;
	}
}

//[Obsolete("分頁旹應把每頁內容全載入內存洏非懶加載")]
public partial class PageAsyE<T>
	:I_TotCnt
	,IPageQry
	,IPageAsyE<T>
{
	public PageAsyE(){}

	public static IPageAsyE<T> Mk(
		IPageQry Qry
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new PageAsyE<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			DataAsyE = DataAsy,
			HasTotCnt = HasTotalCount,
		};
		return R;
	}


	[Obsolete("直接new + 屬性初始化塊")]
	public static IPageAsyE<T> Mk(
		IPageQry Qry
		,u64 TotalCount
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
	){
		var R = new PageAsyE<T>(){
			TotCnt = TotalCount,
			PageQry = Qry,
			DataAsyE = DataAsy,
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
	public IAsyncEnumerable<T>? DataAsyE{get;set;}

}
