namespace Tsinswreng.CsPage;
/// <summary>
/// 分頁查詢中 請求查詢總數
/// 縱設潙true亦未必應
/// </summary>
public  partial interface I_WantTotalCount{
	public bool WantTotalCount{get;set;}
}

/// <summary>
/// 分頁查詢ʹ果中 是否有總記錄數
/// </summary>
public  partial interface I_HasTotalCount{
	public bool HasTotalCount{get;set;}
}
