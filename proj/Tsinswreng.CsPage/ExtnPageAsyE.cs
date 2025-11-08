namespace Tsinswreng.CsPage;


public static class ExtnPageAsyE{
	public static async Task<IPage<T>> ToSyncPage<T>(
		this IPageAsyE<T> z, CT Ct
	){
		var R = new Page<T>{
			TotCnt = z.TotCnt,
			PageIdx = z.PageIdx,
			PageSize = z.PageSize,
			HasTotCnt = z.HasTotCnt,
		};
		if(z.DataAsyE is null){
			R.Data = null;
			return R;
		}
		R.Data = new List<T>();
		await foreach(var e in z.DataAsyE){
			R.Data.Add(e);
		}
		return R;
	}
	public static async Task<IPageAsyE<T>> ToPageAsyE<T>(
		this IPage<T> z, CT Ct
	){
		var R = new PageAsyE<T>{
			TotCnt = z.TotCnt,
			PageIdx = z.PageIdx,
			PageSize = z.PageSize,
			HasTotCnt = z.HasTotCnt,
		};
		if(z.Data is null){
			return R;
		}

		async IAsyncEnumerable<T> fn(IEnumerable<T> Data){
			foreach(var ele in Data){
				yield return ele;
			}
		}
		R.DataAsyE = fn(z.Data);
		return R;
	}
}
