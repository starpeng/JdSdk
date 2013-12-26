JdSdk
=====

京东开放平台.NET版sdk 

[最新版DLL下载](https://github.com/starpeng/JdSdk/raw/master/Releases/JdSdk.NET%201.4.1.zip "1.4.1")

[最新版源码下载](https://github.com/starpeng/JdSdk/archive/master.zip "Surce ")

[问题反馈](https://github.com/starpeng/JdSdk/issues/new "问题反馈")
>使用Github中的Issue和Pull Request来反馈问题。  
>如果仅是提交问题，请使用[Issue](https://github.com/starpeng/JdSdk/issues/new "问题提交")  
>如您已修正问题代码，并愿分享代码，请使用[Pull Request](https://github.com/starpeng/JdSdk/compare/ "代码提交")  

交流QQ群：[236361019](http://wp.qq.com/wpa/qunwpa?idkey=cf2359d5237e19515d77680427f38b46dc3d2dfa4ef596c21edbc1205413efab "236361019")
<a target="_blank" href="http://wp.qq.com/wpa/qunwpa?idkey=cf2359d5237e19515d77680427f38b46dc3d2dfa4ef596c21edbc1205413efab"><img border="0" src="http://pub.idqqimg.com/wpa/images/group.png" alt="SDK交流" title="SDK交流"></a>
  
  
  
源码托管地址：  
[GitHub：https://github.com/starpeng/JdSdk/](https://github.com/starpeng/JdSdk/)  
[京东：https://code.jd.com/starpeng/JdSdk.NET](https://code.jd.com/starpeng/JdSdk.NET)  


## 更新记录 ##

-1.4.1
>  jingdong.vender.shop.query 补充响应实体   
>  加入对京东长整形时间类型的反序列化  

-1.4.0
>新增接口UniversalRequest作为通用的一个接口访问，可以使用该接口访问任何接口，需要自行指定ApiName和通过AddParam增加参数。  
>Respone中加入Json属性，为接口返回数据的JSON object,可以自行进行值的获取和解析。  
>其它修改约20个接口，新增约27个接口。  

-1.3.6
>

-1.3.5
>修正接口jingdong.imgzone.category.query 查询参数修改为可空类型    

-1.3.5
>修正接口jingdong.imgzone.picture.upload  传入图片数据参数ImageData为Byte[]    

-1.3.4
>jingdong.seller.vender.info.get返回的不是数组    

-1.3.2
>类型OrderItem文档中商品编号ware_id，实测实际为ware  


-1.3.1
>接口jingdong.etms.waybillcode.get 修正  


-1.3.0  
新增接口
>获取工单列表   jingdong.wos.worklist.get  
>获取工单信息  jingdong.wos.workinfo.get  
>获取二级业务类型列表   jingdong.wos.subbiztypelist.get  
>商家回复工单 jingdong.rest.workorder.reply  
>更新图片 jingdong.imgzone.picture.update  
>替换图片 jingdong.imgzone.picture.replace  
>查询图片空间用户信息 jingdong.imgzone.userinfo.query  
>查询图片是否被引用 jingdong.imgzone.picture.isreferenced  
>FBP订单检索  360buy.order.fbp.search   
>FBP获取单个订单  360buy.order.fbp.get  
>删单申请 jingdong.order.orderDelete.apply  
>查询商家备注 jingdong.order.venderRemark.queryByOrderId  
>青龙全程跟踪查询接口  jingdong.etms.trace.get  
>设置商品限购区域 360buy.ware.area.limit.update  
>查询商品限购区域 360buy.ware.area.limit.search  
>修改商品关联版式 360buy.ware.template.update  
>删除商品关联版式 360buy.ware.template.delete    
>查询关联版式id以及名称 360buy.ware.template.ids.names.get   
>查询关联版式详情 360buy.ware.template.get   
>设置关联版式到商品 360buy.ware.template.to.wares.update  
>面向用户服务（类目服务） http://help.jd.com/jos/question-627.html
>面向用户服务（商品服务）接口 http://help.jd.com/jos/question-628.html  
>京东快车新增修改类2接口 http://help.jd.com/jos/question-813.html  
>数据罗盘、店铺数据9接口 http://help.jd.com/jos/question-878.html  
>面向卖家服务新增商品关联版式6个接口	 http://help.jd.com/jos/question-877.html  
>售后服务10接口 http://help.jd.com/jos/question-568.html  
>咚咚服务11接口 http://help.jd.com/jos/question-879.html  
>   


 
变更接口  
>购买该商品的人最终购买了 jingdong.ware.buytobuy.list.get  
>浏览过该商品的人最终购买了 jingdong.ware.browsetobuy.list.get  
>获得商品最佳购买组合 jingdong.ware.combine.list.get  
>获得商品组合套装  jingdong.ware.packs.get  
>获取京东物流运单号接口 jingdong.etms.waybillcode.get  
>京东物流接单接口  jingdong.etms.waybill.send  
  
  
-1.2.0
>重构代码，接口加入附加参数，以支持随时可能新增的请求参数  
>Json.Net改为使用dll引用  
>wares.search接口补充ware_status,start_modified,end_modified请求参数  
  
-1.1.6
>SkuStockUpdateResponse 更改SkuId为可空类型  
>优惠明细CouponDetail.SkuId改为String类型  


-1.1.5
> 修改一些数据类型。  
> 根据ware_id 商品编号 修改商品信息接口，去掉部分参数的必须验证   

-1.1.4
> SOP,LBP,SOPL服务接口中的流水号设置为非必须参数。  

  
-1.1.3
> 更新库存接口SkuId修改为可空类型   


- 1.1.2
> 京东快车 13个接口  
> 促销服务14个接口  
> 物流服务19个接口  
> 地址库接口共5个  
> 京东快车新增4接口  
> 图片空间6接口  
> 订购关系查询 jingdong.vas.subscribe.get  
> 获取预分配的运单号jingdong.etms.waybillcode.get  
> 提交运单信息 jingdong.etms.waybill.send  
> 获取类目信息 jingdong.union.categoryinfo.search  
> 保存计划信息 jingdong.union.plan.save  
> 获取计划基本信息 jingdong.union.planbaseinfo.get  
> 根据pin返回供应商简码和三级分类列表 jingdong.userCategory3.info.get
> 若干接口同步修改
  
  
    
  
- 1.1.1
> 360buy.order.search，360buy.order.get支持返回运单号、物流公司、增值税发票


- 1.1.0
> 将部分京东文档中为Number，明显为整形字段的由原来的Decimal替换成换成Int64。

- 1.0.9
> 增加13个直通车接口


- 1.0.8
> 修正获取上下架商品接口的错误


- 1.0.7

> ####新增接口
> 商家信息接口 jingdong.seller.vender.info.get  
海外购发货接口 360buy.overseas.order.sop.delivery  
海外购出库接口 360buy.overseas.order.sop.outstorage  
SOPL修改运单号 360buy.order.sopl.waybill.update  
LBP修改运单号 360buy.order.lbp.waybill.update  
CPS服务共18个接口 （接口名-略）  
根据SKUID获取商品价格 jingdong.ware.price.get  

>####更新接口
获取商品促销信息的接口 jingdong.ware.promotionInfo.get  
SOP修改运单号 360buy.order.sop.waybill.update  
检索商品信息接口  360buy.wares.search  
根据商品ID查询单个商品的详细信息 360buy.ware.get  
批量获取商品信息 360buy.wares.list.get  
检索商品信息接口  360buy.wares.search  
上架商品 360buy.ware.listing.get  
下架商品 360buy.ware.delisting.get  
