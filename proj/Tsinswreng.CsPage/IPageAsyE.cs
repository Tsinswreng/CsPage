using Tsinswreng.CsCore;

namespace Tsinswreng.CsPage;


[Doc(@$"Page Result")]
public partial interface IPageAsyE<T>
	:IPageResultInfo
{
	public IAsyncEnumerable<T>? DataAsyE{get;set;}

}
