namespace Tsinswreng.CsPage;

/// 分頁ʹ果
public partial interface IPage<T>
	:IPageResultInfo
{
	public IList<T>? Data{get;set;}
}
