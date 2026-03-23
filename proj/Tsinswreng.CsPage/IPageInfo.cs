namespace Tsinswreng.CsPage;


/// 頁ˉ自ʹ訊、含大小與索引等
public partial interface IPageInfo{
	/// from 0
	public u64 PageIdx{get;set;}
	public u64 PageSize{get;set;}
}
