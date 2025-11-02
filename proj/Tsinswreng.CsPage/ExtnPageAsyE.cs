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
}
