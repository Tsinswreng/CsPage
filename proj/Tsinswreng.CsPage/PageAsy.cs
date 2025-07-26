namespace Tsinswreng.CsPage;

using System.Runtime.CompilerServices;
using Tsinswreng.CsCore;


/// <summary>
///
/// </summary>
/// <typeparam name="T"></typeparam>
public  partial class PageAsy<T>
	:I_TotalCount
	,IPageQuery
	,IPageAsy<T>
{
	public PageAsy(){}

	public static IPageAsy<T> Mk(
		IPageQuery Qry
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
		,u64 TotalCount = 0
	){
		var R = new PageAsy<T>(){
			TotalCount = TotalCount,
			PageQry = Qry,
			DataAsy = DataAsy,
			HasTotalCount = HasTotalCount,
		};
		return R;
	}


	[Obsolete("直接new + 屬性初始化塊")]
	public static IPageAsy<T> Mk(
		IPageQuery Qry
		,u64 TotalCount
		,IAsyncEnumerable<T>? DataAsy
		,bool HasTotalCount = false
	){
		var R = new PageAsy<T>(){
			TotalCount = TotalCount,
			PageQry = Qry,
			DataAsy = DataAsy,
			HasTotalCount = HasTotalCount,
		};
		return R;
	}

	public IPageQuery PageQry{
		get{
			return new PageQuery{
				PageIndex = this.PageIndex
				,PageSize = this.PageSize
				,WantTotalCount = this.WantTotalCount
			};
		}
		set{
			PageIndex = value.PageIndex;
			PageSize = value.PageSize;
			WantTotalCount = value.WantTotalCount;
		}
	}

	[Impl]
	public bool WantTotalCount{get;set;}
	[Impl]
	public bool HasTotalCount{get;set;}
	[Impl]
	public u64 TotalCount{get;set;}
	[Impl]
	public u64 PageIndex{get;set;}
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
		return z.PageIndex * z.PageSize;
	}
}
