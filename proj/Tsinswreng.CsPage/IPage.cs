namespace Tsinswreng.CsPage;
/// <summary>
/// 分頁ʹ果
/// </summary>
/// <typeparam name="T"></typeparam>
public partial interface IPage<T>
	:I_TotCnt
	,IPageInfo
	,I_HasTotCnt
{
	public IList<T>? Data{get;set;}
}
