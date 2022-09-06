using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class Root
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("site_id")]
    public string? SiteId { get; set; }

    [JsonPropertyName("title")]
    public string? ProductTitle { get; set; }

    [JsonPropertyName("subtitle")]
    public string? ProductSubtitle { get; set; }

    [JsonPropertyName("seller_id")]
    public long? SellerId { get; set; }

    [JsonPropertyName("category_id")]
    public string? CategoryId { get; set; }

    [JsonPropertyName("official_store_id")]
    public long? OfficialStoreId { get; set; }

    [JsonPropertyName("price")]
    public double? Price { get; set; }

    [JsonPropertyName("base_price")]
    public double? BasePrice { get; set; }

    [JsonPropertyName("original_price")]
    public double? OriginalPrice { get; set; }

    [JsonPropertyName("currency_id")]
    public string? CurrencyId { get; set; }

    [JsonPropertyName("initial_quantity")]
    public long? InitialQuantity { get; set; }

    [JsonPropertyName("available_quantity")]
    public long? AvailableQuantity { get; set; }

    [JsonPropertyName("sold_quantity")]
    public long? SoldQuantity { get; set; }

    [JsonPropertyName("sale_terms")]
    public List<SaleTerms>? SaleTerms { get; set; }

    [JsonPropertyName("buying_mode")]
    public string? BuyingMode { get; set; }

    [JsonPropertyName("listing_type_id")]
    public string? ListingTypeId { get; set; }

    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("stop_time")]
    public DateTime? StopTime { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("permalink")]
    public string? Permalink { get; set; }

    [JsonPropertyName("thumbnail_id")]
    public string? ThumbnailId { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("secure_thumbnail")]
    public string? SecureThumbnail { get; set; }

    [JsonPropertyName("pictures")]
    public List<Pictures>? Pictures { get; set; }

    [JsonPropertyName("video_id")]
    public string? VideoId { get; set; }

    [JsonPropertyName("descriptions")]
    public List<string>? Descriptions { get; set; }

    [JsonPropertyName("accepts_mercadopago")]
    public bool? AcceptsMercadoPago { get; set; }

    [JsonPropertyName("non_mercado_pago_payment_methods")]
    public List<string>? NonMercadoPagoPaymentMethods { get; set; }

    [JsonPropertyName("shipping")]
    public Shipping? Shipping { get; set; }

    [JsonPropertyName("international_delivery_mode")]
    public string? InternationalDeliveryMode { get; set; }

    [JsonPropertyName("seller_address")]
    public Address? SellerAddress { get; set; }

    [JsonPropertyName("seller_contact")]
    public string? SellerContact { get; set; }

    [JsonPropertyName("location")]
    public Location? Location { get; set; }

    [JsonPropertyName("coverage_areas")]
    public List<Address>? CoverageAreas { get; set; }

    [JsonPropertyName("attributes")]
    public List<Attributes>? Attributes { get; set; }

    [JsonPropertyName("warnings")]
    public List<string>? Warnings { get; set; }

    [JsonPropertyName("listing_source")]
    public string? ListingSource { get; set; }

    [JsonPropertyName("variation")]
    public List<string>? Variations { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("sub_status")]
    public List<string>? SubStatus { get; set; }

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

    [JsonPropertyName("warranty")]
    public string? Warranty { get; set; }

    [JsonPropertyName("catalog_product_id")]
    public string? CatalogProductId { get; set; }

    [JsonPropertyName("domain_id")]
    public string? DomainId { get; set; }

    [JsonPropertyName("parent_item_id")]
    public string? ParentItemId { get; set; }

    [JsonPropertyName("diferential_pricing")]
    public string? DiferentialPricing { get; set; }

    [JsonPropertyName("deal_ids")]
    public List<string>? DealIds { get; set; }

    [JsonPropertyName("automatic_relist")]
    public bool? AutomaticRelist { get; set; }

    [JsonPropertyName("date_created")]
    public DateTime? DateCreated { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }

    [JsonPropertyName("health")]
    public double? Health { get; set; }

    [JsonPropertyName("catalog_listing")]
    public bool? CatalogListing { get; set; }

    [JsonPropertyName("channels")]
    public List<string>? Channels { get; set; }
}