namespace Tsinswreng.CsPage;
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
