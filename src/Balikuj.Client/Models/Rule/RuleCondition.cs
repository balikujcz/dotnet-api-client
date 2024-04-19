using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Rule
{
    public class RuleCondition
    {
        private string _field;
        private string _operator;

        /// <summary>
        /// Name of column, which will be compared
        /// </summary>
        /// <example>OrderPaid</example>
        public string Field
        {
            get
            {
                // Orders
                if (_field.ToUpperInvariant() == "ORDERNUMBER")
                {
                    return "OrderNumber";
                }
                else if (_field.ToUpperInvariant() == "ORDERSTATUS")
                {
                    return "OrderStatus";
                }
                else if (_field.ToUpperInvariant() == "ORDERCARRIER")
                {
                    return "OrderCarrier";
                }
                else if (_field.ToUpperInvariant() == "ORDERPAYMENT")
                {
                    return "OrderPayment";
                }
                else if (_field.ToUpperInvariant() == "ORDERNOTE")
                {
                    return "OrderNote";
                }
                else if (_field.ToUpperInvariant() == "ORDERPRODUCTCODE")
                {
                    return "OrderProductCode";
                }
                else if (_field.ToUpperInvariant() == "ORDERPRODUCTNAME")
                {
                    return "OrderProductName";
                }
                else if (_field.ToUpperInvariant() == "ORDERPAID")
                {
                    return "OrderPaid";
                }
                else if (_field.ToUpperInvariant() == "ORDERCREATEDFROM")
                {
                    return "OrderCreatedFrom";
                }
                else if (_field.ToUpperInvariant() == "ORDERITEMSINSTORE")
                {
                    return "OrderItemsInStore";
                }
                else if (_field.ToUpperInvariant() == "ORDERNOITEMSINSTORE")
                {
                    return "OrderNoItemsInStore";
                }
                else if (_field.ToUpperInvariant() == "ORDERSOMEITEMSINSTORE")
                {
                    return "OrderSomeItemsInStore";
                }
                else if (_field.ToUpperInvariant() == "ORDERUPDATEDDAYS")
                {
                    return "OrderUpdatedDays";
                }
                else if (_field.ToUpperInvariant() == "ORDERORDEREDXTIMES")
                {
                    return "OrderOrderedXTimes";
                }
                else if (_field.ToUpperInvariant() == "ORDERPRICEVALUE")
                {
                    return "OrderPriceValue";
                }
                else if (_field.ToUpperInvariant() == "ORDERCUSTOMERTAX")
                {
                    return "OrderCustomerTax";
                }
                else if (_field.ToUpperInvariant() == "ORDERCUSTOMERTAXNUMBER")
                {
                    return "OrderCustomerTaxNumber";
                }
                else if (_field.ToUpperInvariant() == "ORDERCUSTOMERVATNUMBER")
                {
                    return "OrderCustomerVatNumber";
                }
                else if (_field.ToUpperInvariant() == "ORDERCUSTOMERSTATE")
                {
                    return "OrderCustomerState";
                }
                else if (_field.ToUpperInvariant() == "ORDERDELIVERYADDRESSSTREET")
                {
                    return "OrderDeliveryAddressStreet";
                }
                else if (_field.ToUpperInvariant() == "ORDERDELIVERYADDRESSZIP")
                {
                    return "OrderDeliveryAddressZip";
                }
                else if (_field.ToUpperInvariant() == "ORDERDELIVERYADDRESSCITY")
                {
                    return "OrderDeliveryAddressCity";
                }
                else if (_field.ToUpperInvariant() == "ORDERBILLINGADDRESSSTREET")
                {
                    return "OrderBillingAddressStreet";
                }
                else if (_field.ToUpperInvariant() == "ORDERBILLINGADDRESSZIP")
                {
                    return "OrderBillingAddressZip";
                }
                else if (_field.ToUpperInvariant() == "ORDERBILLINGADDRESSCITY")
                {
                    return "OrderBillingAddressCity";
                }
                else if (_field.ToUpperInvariant() == "ORDERWEIGHT")
                {
                    return "OrderWeight";
                }
                else if (_field.ToUpperInvariant() == "ORDERPACKAGEEXISTS")
                {
                    return "OrderPackageExists";
                }
                // packages
                else if (_field.ToUpperInvariant() == "PACKAGECARRIER")
                {
                    return "PackageCarrier";
                }
                else if (_field.ToUpperInvariant() == "PACKAGELASTSTATUSCATEGORY")
                {
                    return "PackageLastStatusCategory";
                }
                else if (_field.ToUpperInvariant() == "PACKAGEANYSTATUSCATEGORY")
                {
                    return "PackageAnyStatusCategory";
                }
                else if (_field.ToUpperInvariant() == "PACKAGELASTSTATUSTEXT")
                {
                    return "PackageLastStatusText";
                }
                else if (_field.ToUpperInvariant() == "PACKAGEANYSTATUSTEXT")
                {
                    return "PackageAnyStatusText";
                }
                else if (_field.ToUpperInvariant() == "PACKAGENUMBERCUSTOM")
                {
                    return "PackageNumberCustom";
                }
                else if (_field.ToUpperInvariant() == "PACKAGENUMBERCARRIER")
                {
                    return "PackageNumberCarrier";
                }
                else if (_field.ToUpperInvariant() == "PACKAGECOD")
                {
                    return "PackageCod";
                }

                else
                {
                    return _field;
                }
            }
            set { _field = value; }
        }

        /// <summary>
        /// Operator, which will be used for comparison. List of available operators can be obtained by calling the /Rule/Fields method
        /// </summary>
        /// <example>EqualTo</example>
        public string Operator
        {
            get
            {
                if (_operator.ToUpperInvariant() == "EQUALTO")
                {
                    return "EqualTo";
                }
                else if (_operator.ToUpperInvariant() == "NOTEQUALTO")
                {
                    return "NotEqualTo";
                }
                else if (_operator.ToUpperInvariant() == "GREATERTHAN")
                {
                    return "GreaterThan";
                }
                else if (_operator.ToUpperInvariant() == "GREATERTHANOREQUALTO")
                {
                    return "GreaterThanOrEqualTo";
                }
                else if (_operator.ToUpperInvariant() == "LESSTHAN")
                {
                    return "LessThan";
                }
                else if (_operator.ToUpperInvariant() == "LESSTHANOREQUALTO")
                {
                    return "LessThanOrEqualTo";
                }
                else if (_operator.ToUpperInvariant() == "CONTAINS")
                {
                    return "Contains";
                }
                else if (_operator.ToUpperInvariant() == "DOESNOTCONTAIN")
                {
                    return "DoesNotContain";
                }
                else if (_operator.ToUpperInvariant() == "BEGINSWITH")
                {
                    return "BeginsWith";
                }
                else if (_operator.ToUpperInvariant() == "DOESNOTBEGINWITH")
                {
                    return "DoesNotBeginWith";
                }
                else if (_operator.ToUpperInvariant() == "ENDSWITH")
                {
                    return "EndsWith";
                }
                else if (_operator.ToUpperInvariant() == "DOESNOTENDWITH")
                {
                    return "DoesNotEndWith";
                }
                else
                {
                    return _operator;
                }

            }
            set { _operator = value; }
        }

        /// <summary>
        /// Value, which will be used for comparison
        /// </summary>
        /// <example>True</example>
        public string Value { get; set; }
    }
}
