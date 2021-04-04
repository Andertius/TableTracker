package DBClasses;

public class Place {
    public int Id;
    public String Cuisine;
    public double Height;
    public int PlaceId;
    public String PlaceType;
    public double PriceRange;
    public double Width;
    public Place(){}
    public Place(int id, String cuisine,double height, int placeId, String placeType, double priceRange, double width )
    {
        Id=id;
        Cuisine=cuisine;
        Height = height;
        PlaceId = placeId;
        PlaceType = placeType;
        PriceRange = priceRange;
        Width = width;
    }

}
