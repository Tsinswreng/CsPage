#import "@preview/tsinswreng-auto-heading:0.1.0": auto-heading
#let H = auto-heading;

#H[Tsinswreng.CsPage][
	Tsinswreng.CsPage 是一組分頁查詢與分頁結果模型。

	它適合用在：

	- 查詢請求中的頁碼/頁大小建模
	- 分頁結果返回
	- 帶或不帶總數的列表接口
	- 基於 `IAsyncEnumerable<T>` 的分頁迭代

	#H[安裝][
		```bash
		dotnet add package Tsinswreng.CsPage --version 0.0.1-alpha
		```
	]
]
