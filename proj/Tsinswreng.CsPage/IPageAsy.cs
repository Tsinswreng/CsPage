namespace Tsinswreng.CsPage;

/// <summary>
/// 分頁ʹ果
/// </summary>
/// <typeparam name="T"></typeparam>
//[Obsolete("分頁旹應把每頁內容全載入內存洏非懶加載")]
public partial interface IPageAsyE<T>
	:I_TotCnt
	,IPageInfo
	,I_HasTotCnt
{
	public IAsyncEnumerable<T>? DataAsyE{get;set;}

}
