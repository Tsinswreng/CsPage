namespace Tsinswreng.CsPage;

/// <summary>
/// 頁ˉ自ʹ訊、含大小與索引等
/// </summary>
public  partial interface IPageInfo{
	/// <summary>
	/// from 0
	/// </summary>
	public u64 PageIndex{get;set;}
	public u64 PageSize{get;set;}
}
