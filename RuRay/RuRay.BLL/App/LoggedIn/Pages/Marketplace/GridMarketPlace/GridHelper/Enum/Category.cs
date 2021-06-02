using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the ApparelCategory.
    /// </summary>
    public enum ApparelCategory
    {
        /// <summary>
        /// Defines the Womens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Womens), typeof(ResCategory))]
        Womens = 0,

        /// <summary>
        /// Defines the Mens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mens), typeof(ResCategory))]
        Mens = 1,

        /// <summary>
        /// Defines the KidsClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KidsClothing), typeof(ResCategory))]
        KidsClothing = 2,

        /// <summary>
        /// Defines the BabyClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyClothing), typeof(ResCategory))]
        BabyClothing = 3,

        /// <summary>
        /// Defines the Shoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Shoes), typeof(ResCategory))]
        Shoes = 4,

        /// <summary>
        /// Defines the JewelryAndAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.JewelryAndAccessories), typeof(ResCategory))]
        JewelryAndAccessories = 5,

        /// <summary>
        /// Defines the BagsAndLuggage.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BagsAndLuggage), typeof(ResCategory))]
        BagsAndLuggage = 6,

        /// <summary>
        /// Defines the HalloweenAndKidsCostumes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HalloweenAndKidsCostumes), typeof(ResCategory))]
        HalloweenAndKidsCostumes = 7,

        /// <summary>
        /// Defines the UniformsAndWorkClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.UniformsAndWorkClothing), typeof(ResCategory))]
        UniformsAndWorkClothing = 8
    }

    /// <summary>
    /// Defines the BathProductsCategory.
    /// </summary>
    public enum BathProductsCategory
    {
        /// <summary>
        /// Defines the BathLinens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BathLinens), typeof(ResCategory))] BathLinens = 0,

        /// <summary>
        /// Defines the BathroomScales.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BathroomScales), typeof(ResCategory))] BathroomScales = 1,

        /// <summary>
        /// Defines the MedicineCabinets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MedicineCabinets), typeof(ResCategory))] MedicineCabinets = 2,

        /// <summary>
        /// Defines the ShowerHeads.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ShowerHeads), typeof(ResCategory))] ShowerHeads = 3,
    }

    /// <summary>
    /// Defines the BicyclesCategory.
    /// </summary>
    public enum BicyclesCategory
    {
        /// <summary>
        /// Defines the BicycleAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BicycleAccessories), typeof(ResCategory))] BicycleAccessories = 0,

        /// <summary>
        /// Defines the BicycleParts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BicycleParts), typeof(ResCategory))] BicycleParts = 1,
    }

    /// <summary>
    /// Defines the CleaningSuppliesCategory.
    /// </summary>
    public enum CleaningSuppliesCategory
    {
        /// <summary>
        /// Defines the MopsAndBrooms.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MopsAndBrooms), typeof(ResCategory))] MopsAndBrooms = 0,
    }

    /// <summary>
    /// Defines the BeddingCategory.
    /// </summary>
    public enum BeddingCategory
    {
        /// <summary>
        /// Defines the BedSheets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BedSheets), typeof(ResCategory))] BedSheets = 0,

        /// <summary>
        /// Defines the BeddingSets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BeddingSets), typeof(ResCategory))] BeddingSets = 1,

        /// <summary>
        /// Defines the BedspreadsAndQuilts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BedspreadsAndQuilts), typeof(ResCategory))] BedspreadsAndQuilts = 2,

        /// <summary>
        /// Defines the BlanketsAndThrows.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BlanketsAndThrows), typeof(ResCategory))] BlanketsAndThrows = 3,

        /// <summary>
        /// Defines the Comforters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Comforters), typeof(ResCategory))] Comforters = 4,
    }

    /// <summary>
    /// Defines the OfficeFurnitureCategory.
    /// </summary>
    public enum OfficeFurnitureCategory
    {
        /// <summary>
        /// Defines the Desks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Desks), typeof(ResCategory))] Desks = 0,

        /// <summary>
        /// Defines the FilingCabinets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FilingCabinets), typeof(ResCategory))] FilingCabinets = 1,

        /// <summary>
        /// Defines the OfficeChairs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OfficeChairs), typeof(ResCategory))] OfficeChairs = 2,
    }

    /// <summary>
    /// Defines the HomeGoodsCategory.
    /// </summary>
    public enum HomeGoodsCategory
    {
        /// <summary>
        /// Defines the Appliances.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Appliances), typeof(ResCategory))] Appliances = 0,

        /// <summary>
        /// Defines the BathProducts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BathProducts), typeof(ResCategory))] BathProducts = 1,

        /// <summary>
        /// Defines the Bedding.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Bedding), typeof(ResCategory))] Bedding = 2,

        /// <summary>
        /// Defines the CleaningSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CleaningSupplies), typeof(ResCategory))] CleaningSupplies = 3,

        /// <summary>
        /// Defines the Furniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Furniture), typeof(ResCategory))] Furniture = 4,

        /// <summary>
        /// Defines the HomeDecor.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeDecor), typeof(ResCategory))] HomeDecor = 5,

        /// <summary>
        /// Defines the HomeImprovementSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeImprovementSupplies), typeof(ResCategory))] HomeImprovementSupplies = 6,

        /// <summary>
        /// Defines the HomeLighting.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeLighting), typeof(ResCategory))] HomeLighting = 7,

        /// <summary>
        /// Defines the KitchenAndDiningProducts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KitchenAndDiningProducts), typeof(ResCategory))] KitchenAndDiningProducts = 8,

        /// <summary>
        /// Defines the StorageAndOrganization.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StorageAndOrganization), typeof(ResCategory))] StorageAndOrganization = 9,

        /// <summary>
        /// Defines the Tools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Tools), typeof(ResCategory))] Tools = 10,

        /// <summary>
        /// Defines the GardenAndOutdoor.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GardenAndOutdoor), typeof(ResCategory))] GardenAndOutdoor = 11
    }

    /// <summary>
    /// Defines the HomeDecorCategory.
    /// </summary>
    public enum HomeDecorCategory
    {
        /// <summary>
        /// Defines the Clocks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Clocks), typeof(ResCategory))] Clocks = 0,

        /// <summary>
        /// Defines the DecorativeAccents.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DecorativeAccents), typeof(ResCategory))] DecorativeAccents = 1,

        /// <summary>
        /// Defines the HolidayDecor.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HolidayDecor), typeof(ResCategory))] HolidayDecor = 2,

        /// <summary>
        /// Defines the HomeFragrances.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeFragrances), typeof(ResCategory))] HomeFragrances = 3,

        /// <summary>
        /// Defines the Mirrors.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mirrors), typeof(ResCategory))] Mirrors = 4,

        /// <summary>
        /// Defines the RugsAndCarpets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RugsAndCarpets), typeof(ResCategory))] RugsAndCarpets = 5,
    }

    /// <summary>
    /// Defines the HomeImprovementSuppliesCategory.
    /// </summary>
    public enum HomeImprovementSuppliesCategory
    {
        /// <summary>
        /// Defines the BathroomVanities.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BathroomVanities), typeof(ResCategory))] BathroomVanities = 0,

        /// <summary>
        /// Defines the Bathtubs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Bathtubs), typeof(ResCategory))] Bathtubs = 1,

        /// <summary>
        /// Defines the Countertops.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Countertops), typeof(ResCategory))] Countertops = 2,

        /// <summary>
        /// Defines the Doors.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Doors), typeof(ResCategory))] Doors = 3,

        /// <summary>
        /// Defines the Gutters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Gutters), typeof(ResCategory))] Gutters = 4,

        /// <summary>
        /// Defines the HomeHeatingAndCooling.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeHeatingAndCooling), typeof(ResCategory))] HomeHeatingAndCooling = 5,

        /// <summary>
        /// Defines the KitchenCabinets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KitchenCabinets), typeof(ResCategory))] KitchenCabinets = 6,

        /// <summary>
        /// Defines the Mailboxes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mailboxes), typeof(ResCategory))] Mailboxes = 7,

        /// <summary>
        /// Defines the ShowersAndShowerParts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ShowersAndShowerParts), typeof(ResCategory))] ShowersAndShowerParts = 8,

        /// <summary>
        /// Defines the VinylFlooring.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VinylFlooring), typeof(ResCategory))] VinylFlooring = 9,

        /// <summary>
        /// Defines the Tools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Tools), typeof(ResCategory))] Tools = 10,
    }

    /// <summary>
    /// Defines the ShowersAndShowerPartsCategory.
    /// </summary>
    public enum ShowersAndShowerPartsCategory
    {
        /// <summary>
        /// Defines the ShowerHeads.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ShowerHeads), typeof(ResCategory))] ShowerHeads = 0
    }

    /// <summary>
    /// Defines the HomeHeatingAndCoolingCategory.
    /// </summary>
    public enum HomeHeatingAndCoolingCategory
    {
        /// <summary>
        /// Defines the AirConditioners.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirConditioners), typeof(ResCategory))] AirConditioners = 0,

        /// <summary>
        /// Defines the AirPurifiers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirPurifiers), typeof(ResCategory))] AirPurifiers = 1,

        /// <summary>
        /// Defines the Dehumidifiers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Dehumidifiers), typeof(ResCategory))] Dehumidifiers = 2,

        /// <summary>
        /// Defines the Fans.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Fans), typeof(ResCategory))] Fans = 3,

        /// <summary>
        /// Defines the FireplacesAndStoves.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FireplacesAndStoves), typeof(ResCategory))] FireplacesAndStoves = 4,

        /// <summary>
        /// Defines the Furnaces.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Furnaces), typeof(ResCategory))] Furnaces = 5,

        /// <summary>
        /// Defines the Humidifiers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Humidifiers), typeof(ResCategory))] Humidifiers = 6,

        /// <summary>
        /// Defines the SpaceHeaters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SpaceHeaters), typeof(ResCategory))] SpaceHeaters = 7,

        /// <summary>
        /// Defines the Thermostats.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Thermostats), typeof(ResCategory))] Thermostats = 8,
    }

    /// <summary>
    /// Defines the HomeLightingCategory.
    /// </summary>
    public enum HomeLightingCategory
    {
        /// <summary>
        /// Defines the CeilingFans.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CeilingFans), typeof(ResCategory))] CeilingFans = 0,

        /// <summary>
        /// Defines the Chandeliers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Chandeliers), typeof(ResCategory))] Chandeliers = 1,

        /// <summary>
        /// Defines the LampShades.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LampShades), typeof(ResCategory))] LampShades = 2,

        /// <summary>
        /// Defines the Lamps.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Lamps), typeof(ResCategory))] Lamps = 3,

        /// <summary>
        /// Defines the LightBulbs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LightBulbs), typeof(ResCategory))] LightBulbs = 4,

        /// <summary>
        /// Defines the NightLights.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.NightLights), typeof(ResCategory))] NightLights = 5,
    }

    /// <summary>
    /// Defines the PianosAndKeyboardsCategory.
    /// </summary>
    public enum PianosAndKeyboardsCategory
    {
        /// <summary>
        /// Defines the ElectronicKeyboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ElectronicKeyboards), typeof(ResCategory))] ElectronicKeyboards = 0,

        /// <summary>
        /// Defines the Pianos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Pianos), typeof(ResCategory))] Pianos = 1,
    }

    /// <summary>
    /// Defines the KitchenAndDiningProductsCategory.
    /// </summary>
    public enum KitchenAndDiningProductsCategory
    {
        /// <summary>
        /// Defines the BakingPans.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BakingPans), typeof(ResCategory))] BakingPans = 0,

        /// <summary>
        /// Defines the Cookware.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Cookware), typeof(ResCategory))] Cookware = 1,

        /// <summary>
        /// Defines the KitchenUtensils.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KitchenUtensils), typeof(ResCategory))] KitchenUtensils = 2,

        /// <summary>
        /// Defines the PantryOrganizationAndStorage.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PantryOrganizationAndStorage), typeof(ResCategory))] PantryOrganizationAndStorage = 3,

        /// <summary>
        /// Defines the Tableware.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Tableware), typeof(ResCategory))] Tableware = 4,

        /// <summary>
        /// Defines the VacuumSealers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VacuumSealers), typeof(ResCategory))] VacuumSealers = 5,
    }

    /// <summary>
    /// Defines the PatioFurnitureCategory.
    /// </summary>
    public enum PatioFurnitureCategory
    {
        /// <summary>
        /// Defines the Hammocks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Hammocks), typeof(ResCategory))] Hammocks = 0,

        /// <summary>
        /// Defines the OutdoorChairs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorChairs), typeof(ResCategory))] OutdoorChairs = 1,

        /// <summary>
        /// Defines the OutdoorCushions.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorCushions), typeof(ResCategory))] OutdoorCushions = 2,

        /// <summary>
        /// Defines the OutdoorFurnitureSets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorFurnitureSets), typeof(ResCategory))] OutdoorFurnitureSets = 3,

        /// <summary>
        /// Defines the OutdoorHeaters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorHeaters), typeof(ResCategory))] OutdoorHeaters = 4,

        /// <summary>
        /// Defines the OutdoorTables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorTables), typeof(ResCategory))] OutdoorTables = 5,

        /// <summary>
        /// Defines the PatioUmbrellas.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PatioUmbrellas), typeof(ResCategory))] PatioUmbrellas = 6
    }

    /// <summary>
    /// Defines the StorageAndOrganizationCategory.
    /// </summary>
    public enum StorageAndOrganizationCategory
    {
        /// <summary>
        /// Defines the ClothingStorage.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ClothingStorage), typeof(ResCategory))] ClothingStorage = 0,

        /// <summary>
        /// Defines the GeneralStorage.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GeneralStorage), typeof(ResCategory))] GeneralStorage = 1,
    }

    /// <summary>
    /// Defines the ToolsCategory.
    /// </summary>
    public enum ToolsCategory
    {
        /// <summary>
        /// Defines the AirTools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirTools), typeof(ResCategory))] AirTools = 0,

        /// <summary>
        /// Defines the Anvils.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Anvils), typeof(ResCategory))] Anvils = 1,

        /// <summary>
        /// Defines the HandTools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HandTools), typeof(ResCategory))] HandTools = 2,

        /// <summary>
        /// Defines the Ladders.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Ladders), typeof(ResCategory))] Ladders = 3,

        /// <summary>
        /// Defines the MeasuringToolsAndSensors.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MeasuringToolsAndSensors), typeof(ResCategory))] MeasuringToolsAndSensors = 4,

        /// <summary>
        /// Defines the ShopVacuums.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ShopVacuums), typeof(ResCategory))] ShopVacuums = 5,

        /// <summary>
        /// Defines the StepStools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StepStools), typeof(ResCategory))] StepStools = 6,

        /// <summary>
        /// Defines the WorkBenches.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WorkBenches), typeof(ResCategory))] WorkBenches = 7,

        /// <summary>
        /// Defines the PowerTools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PowerTools), typeof(ResCategory))] PowerTools = 8,
    }

    /// <summary>
    /// Defines the FurnitureCategory.
    /// </summary>
    public enum FurnitureCategory
    {
        /// <summary>
        /// Defines the AccentFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AccentFurniture), typeof(ResCategory))] AccentFurniture = 0,

        /// <summary>
        /// Defines the BabyFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyFurniture), typeof(ResCategory))] BabyFurniture = 1,

        /// <summary>
        /// Defines the BedroomFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BedroomFurniture), typeof(ResCategory))] BedroomFurniture = 2,

        /// <summary>
        /// Defines the DiningRoomFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DiningRoomFurniture), typeof(ResCategory))] DiningRoomFurniture = 3,

        /// <summary>
        /// Defines the LivingRoomFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LivingRoomFurniture), typeof(ResCategory))] LivingRoomFurniture = 4,

        /// <summary>
        /// Defines the PatioFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PatioFurniture), typeof(ResCategory))] PatioFurniture = 5,
    }

    /// <summary>
    /// Defines the AppliancesCategory.
    /// </summary>
    public enum AppliancesCategory
    {
        /// <summary>
        /// Defines the AirConditioners.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirConditioners), typeof(ResCategory))] AirConditioners = 0,

        /// <summary>
        /// Defines the CoffeeMakers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CoffeeMakers), typeof(ResCategory))] CoffeeMakers = 1,

        /// <summary>
        /// Defines the Dishwashers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Dishwashers), typeof(ResCategory))] Dishwashers = 2,

        /// <summary>
        /// Defines the ElectricFireplaces.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ElectricFireplaces), typeof(ResCategory))] ElectricFireplaces = 3,

        /// <summary>
        /// Defines the FoodProcessors.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FoodProcessors), typeof(ResCategory))] FoodProcessors = 4,

        /// <summary>
        /// Defines the KitchenOvens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KitchenOvens), typeof(ResCategory))] KitchenOvens = 5,

        /// <summary>
        /// Defines the MicrowaveOvens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MicrowaveOvens), typeof(ResCategory))] MicrowaveOvens = 6,

        /// <summary>
        /// Defines the MixersAndBlenders.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MixersAndBlenders), typeof(ResCategory))] MixersAndBlenders = 7,

        /// <summary>
        /// Defines the RefrigeratorsAndFreezers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RefrigeratorsAndFreezers), typeof(ResCategory))] RefrigeratorsAndFreezers = 8,

        /// <summary>
        /// Defines the SteamersAndCookers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SteamersAndCookers), typeof(ResCategory))] SteamersAndCookers = 9,

        /// <summary>
        /// Defines the ToasterOvens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToasterOvens), typeof(ResCategory))] ToasterOvens = 10,

        /// <summary>
        /// Defines the WaffleMakers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WaffleMakers), typeof(ResCategory))] WaffleMakers = 11,

        /// <summary>
        /// Defines the WashersAndDryers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WashersAndDryers), typeof(ResCategory))] WashersAndDryers = 12,
    }

    /// <summary>
    /// Defines the BagsAndLuggageCategory.
    /// </summary>
    public enum BagsAndLuggageCategory
    {
        /// <summary>
        /// Defines the Backpacks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Backpacks), typeof(ResCategory))]
        Backpacks = 0,

        /// <summary>
        /// Defines the FannyPacks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FannyPacks), typeof(ResCategory))]
        FannyPacks = 1,

        /// <summary>
        /// Defines the Luggage.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Luggage), typeof(ResCategory))]
        Luggage = 2,

        /// <summary>
        /// Defines the WomensHandbagsAndPurses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WomensHandbagsAndPurses), typeof(ResCategory))]
        WomensHandbagsAndPurses = 3
    }

    /// <summary>
    /// Defines the OfficeSuppliesCategory.
    /// </summary>
    public enum OfficeSuppliesCategory
    {
        /// <summary>
        /// Defines the BubbleWrap.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BubbleWrap), typeof(ResCategory))] BubbleWrap = 0,

        /// <summary>
        /// Defines the Clipboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Clipboards), typeof(ResCategory))] Clipboards = 1,

        /// <summary>
        /// Defines the DeskOrganizers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DeskOrganizers), typeof(ResCategory))] DeskOrganizers = 2,

        /// <summary>
        /// Defines the Whiteboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Whiteboards), typeof(ResCategory))] Whiteboards = 3,

        /// <summary>
        /// Defines the OfficeFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OfficeFurniture), typeof(ResCategory))] OfficeFurniture = 4
    }

    /// <summary>
    /// Defines the OutdoorCookingCategory.
    /// </summary>
    public enum OutdoorCookingCategory
    {
        /// <summary>
        /// Defines the BarbecueGrills.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BarbecueGrills), typeof(ResCategory))]
        BarbecueGrills = 0,

        /// <summary>
        /// Defines the OutdoorFirePits.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorFirePits), typeof(ResCategory))]
        OutdoorFirePits = 1
    }

    /// <summary>
    /// Defines the OutdoorLightingCategory.
    /// </summary>
    public enum OutdoorLightingCategory
    {
        /// <summary>
        /// Defines the LandscapeLights.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LandscapeLights), typeof(ResCategory))]
        LandscapeLights = 0,

        /// <summary>
        /// Defines the StringLights.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StringLights), typeof(ResCategory))]
        StringLights = 1
    }

    /// <summary>
    /// Defines the HobbiesCategory.
    /// </summary>
    public enum HobbiesCategory
    {
        /// <summary>
        /// Defines the AntiquesAndCollectibles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AntiquesAndCollectibles), typeof(ResCategory))] AntiquesAndCollectibles = 0,

        /// <summary>
        /// Defines the ArtsAndCrafts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ArtsAndCrafts), typeof(ResCategory))] ArtsAndCrafts = 1,

        /// <summary>
        /// Defines the AutoParts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AutoParts), typeof(ResCategory))] AutoParts = 2,

        /// <summary>
        /// Defines the Bicycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Bicycles), typeof(ResCategory))] Bicycles = 3,

        /// <summary>
        /// Defines the FishingGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FishingGear), typeof(ResCategory))] FishingGear = 4,

        /// <summary>
        /// Defines the MusicalInstruments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MusicalInstruments), typeof(ResCategory))] MusicalInstruments = 5,

        /// <summary>
        /// Defines the OutdoorRecreationEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorRecreationEquipment), typeof(ResCategory))] OutdoorRecreationEquipment = 6,

        /// <summary>
        /// Defines the SportingGoods.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SportingGoods), typeof(ResCategory))] SportingGoods = 7,

        /// <summary>
        /// Defines the ToysAndGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToysAndGames), typeof(ResCategory))] ToysAndGames = 8
    }

    /// <summary>
    /// Defines the FishingGearCategory.
    /// </summary>
    public enum FishingGearCategory
    {
        /// <summary>
        /// Defines the FishingRods.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FishingRods), typeof(ResCategory))] FishingRods = 0
    }

    /// <summary>
    /// Defines the AntiquesAndCollectiblesCategory.
    /// </summary>
    public enum AntiquesAndCollectiblesCategory
    {
        /// <summary>
        /// Defines the AntiqueElectronics.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AntiqueElectronics), typeof(ResCategory))] AntiqueElectronics = 0,

        /// <summary>
        /// Defines the AntiqueFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AntiqueFurniture), typeof(ResCategory))] AntiqueFurniture = 1,

        /// <summary>
        /// Defines the CollectibleStamps.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CollectibleStamps), typeof(ResCategory))] CollectibleStamps = 2,

        /// <summary>
        /// Defines the SportsTradingCards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SportsTradingCards), typeof(ResCategory))] SportsTradingCards = 3,

        /// <summary>
        /// Defines the Typewriters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Typewriters), typeof(ResCategory))] Typewriters = 4
    }

    /// <summary>
    /// Defines the AutoPartsCategory.
    /// </summary>
    public enum AutoPartsCategory
    {
        /// <summary>
        /// Defines the CarEnginesAndParts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarEnginesAndParts), typeof(ResCategory))] CarEnginesAndParts = 0,

        /// <summary>
        /// Defines the CarExhaustsAndParts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarExhaustsAndParts), typeof(ResCategory))] CarExhaustsAndParts = 1,

        /// <summary>
        /// Defines the CarSuspensionAndSteering.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarSuspensionAndSteering), typeof(ResCategory))] CarSuspensionAndSteering = 2,

        /// <summary>
        /// Defines the TiresAndWheels.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TiresAndWheels), typeof(ResCategory))] TiresAndWheels = 3
    }

    /// <summary>
    /// Defines the ArtsAndCraftsCategory.
    /// </summary>
    public enum ArtsAndCraftsCategory
    {
        /// <summary>
        /// Defines the DrawingSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DrawingSupplies), typeof(ResCategory))] DrawingSupplies = 0,

        /// <summary>
        /// Defines the PaintingSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PaintingSupplies), typeof(ResCategory))] PaintingSupplies = 1,

        /// <summary>
        /// Defines the ScrapbookingSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ScrapbookingSupplies), typeof(ResCategory))] ScrapbookingSupplies = 2,

        /// <summary>
        /// Defines the Sewing.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Sewing), typeof(ResCategory))] Sewing = 3,

        /// <summary>
        /// Defines the Yarn.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Yarn), typeof(ResCategory))] Yarn = 4
    }

    /// <summary>
    /// Defines the PoolsAndSpasCategory.
    /// </summary>
    public enum PoolsAndSpasCategory
    {
        /// <summary>
        /// Defines the HotTubs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HotTubs), typeof(ResCategory))] HotTubs = 0,

        /// <summary>
        /// Defines the PoolEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PoolEquipment), typeof(ResCategory))] PoolEquipment = 1,

        /// <summary>
        /// Defines the PoolFloats.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PoolFloats), typeof(ResCategory))] PoolFloats = 2,

        /// <summary>
        /// Defines the SwimmingPools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SwimmingPools), typeof(ResCategory))] SwimmingPools = 3,
    }

    /// <summary>
    /// Defines the PowerToolsCategory.
    /// </summary>
    public enum PowerToolsCategory
    {
        /// <summary>
        /// Defines the PowerDrills.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PowerDrills), typeof(ResCategory))] PowerDrills = 0,

        /// <summary>
        /// Defines the Joiners.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Joiners), typeof(ResCategory))] Joiners = 1,

        /// <summary>
        /// Defines the WoodLathes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WoodLathes), typeof(ResCategory))] WoodLathes = 2,

        /// <summary>
        /// Defines the NailGuns.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.NailGuns), typeof(ResCategory))] NailGuns = 3,

        /// <summary>
        /// Defines the Planers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Planers), typeof(ResCategory))] Planers = 4,

        /// <summary>
        /// Defines the Sanders.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Sanders), typeof(ResCategory))] Sanders = 5,

        /// <summary>
        /// Defines the Winches.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Winches), typeof(ResCategory))] Winches = 6,
    }

    /// <summary>
    /// Defines the OutdoorPowerEquipmentCategory.
    /// </summary>
    public enum OutdoorPowerEquipmentCategory
    {
        /// <summary>
        /// Defines the Chainsaws.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Chainsaws), typeof(ResCategory))] Chainsaws = 0,

        /// <summary>
        /// Defines the Edgers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Edgers), typeof(ResCategory))] Edgers = 1,

        /// <summary>
        /// Defines the HedgeTrimmers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HedgeTrimmers), typeof(ResCategory))] HedgeTrimmers = 2,

        /// <summary>
        /// Defines the LeafBlowers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LeafBlowers), typeof(ResCategory))] LeafBlowers = 3,

        /// <summary>
        /// Defines the PressureWashers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PressureWashers), typeof(ResCategory))] PressureWashers = 4,

        /// <summary>
        /// Defines the LawnMowers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LawnMowers), typeof(ResCategory))] LawnMowers = 5
    }

    /// <summary>
    /// Defines the JewelryAndAccessoriesCategory.
    /// </summary>
    public enum JewelryAndAccessoriesCategory
    {
        /// <summary>
        /// Defines the Anklets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Anklets), typeof(ResCategory))]
        Anklets = 0,

        /// <summary>
        /// Defines the Bracelets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Bracelets), typeof(ResCategory))]
        Bracelets = 1,

        /// <summary>
        /// Defines the CharmsAndPendants.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CharmsAndPendants), typeof(ResCategory))]
        CharmsAndPendants = 2,

        /// <summary>
        /// Defines the Cufflinks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Cufflinks), typeof(ResCategory))]
        Cufflinks = 3,

        /// <summary>
        /// Defines the Earrings.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Earrings), typeof(ResCategory))]
        Earrings = 4,

        /// <summary>
        /// Defines the EngagementJewelry.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.EngagementJewelry), typeof(ResCategory))]
        EngagementJewelry = 5,

        /// <summary>
        /// Defines the JewelrySets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.JewelrySets), typeof(ResCategory))]
        JewelrySets = 6,

        /// <summary>
        /// Defines the Necklaces.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Necklaces), typeof(ResCategory))]
        Necklaces = 7,

        /// <summary>
        /// Defines the Rings.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Rings), typeof(ResCategory))]
        Rings = 8,

        /// <summary>
        /// Defines the ScarvesAndBandanas.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ScarvesAndBandanas), typeof(ResCategory))]
        ScarvesAndBandanas = 9,

        /// <summary>
        /// Defines the Sunglasses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Sunglasses), typeof(ResCategory))]
        Sunglasses = 10,

        /// <summary>
        /// Defines the Wallets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Wallets), typeof(ResCategory))]
        Wallets = 11,

        /// <summary>
        /// Defines the Watches.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Watches), typeof(ResCategory))]
        Watches = 12
    }

    /// <summary>
    /// Defines the MusicalInstrumentsCategory.
    /// </summary>
    public enum MusicalInstrumentsCategory
    {
        /// <summary>
        /// Defines the AudioEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AudioEquipment), typeof(ResCategory))] AudioEquipment = 0,

        /// <summary>
        /// Defines the BrassInstruments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BrassInstruments), typeof(ResCategory))] BrassInstruments = 1,

        /// <summary>
        /// Defines the Cellos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Cellos), typeof(ResCategory))] Cellos = 2,

        /// <summary>
        /// Defines the Clarinets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Clarinets), typeof(ResCategory))] Clarinets = 3,

        /// <summary>
        /// Defines the DrumSets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DrumSets), typeof(ResCategory))] DrumSets = 4,

        /// <summary>
        /// Defines the Flutes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Flutes), typeof(ResCategory))] Flutes = 5,

        /// <summary>
        /// Defines the GuitarsAndBasses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GuitarsAndBasses), typeof(ResCategory))] GuitarsAndBasses = 6,

        /// <summary>
        /// Defines the PercussionInstruments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PercussionInstruments), typeof(ResCategory))] PercussionInstruments = 7,

        /// <summary>
        /// Defines the PianosAndKeyboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PianosAndKeyboards), typeof(ResCategory))] PianosAndKeyboards = 8,

        /// <summary>
        /// Defines the Saxophones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Saxophones), typeof(ResCategory))] Saxophones = 9,

        /// <summary>
        /// Defines the Ukuleles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Ukuleles), typeof(ResCategory))] Ukuleles = 10,

        /// <summary>
        /// Defines the Violas.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Violas), typeof(ResCategory))] Violas = 11,

        /// <summary>
        /// Defines the Violins.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Violins), typeof(ResCategory))] Violins = 12,
    }

    /// <summary>
    /// Defines the AudioEquipmentCategory.
    /// </summary>
    public enum AudioEquipmentCategory
    {
        /// <summary>
        /// Defines the AudioInterfaces.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AudioInterfaces), typeof(ResCategory))] AudioInterfaces = 0,
    }

    /// <summary>
    /// Defines the GuitarsAndBassesCategory.
    /// </summary>
    public enum GuitarsAndBassesCategory
    {
        /// <summary>
        /// Defines the AcousticGuitars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AcousticGuitars), typeof(ResCategory))] AcousticGuitars = 0,

        /// <summary>
        /// Defines the BassGuitars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BassGuitars), typeof(ResCategory))] BassGuitars = 1,

        /// <summary>
        /// Defines the ElectricGuitars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ElectricGuitars), typeof(ResCategory))] ElectricGuitars = 2,

        /// <summary>
        /// Defines the GuitarAmps.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GuitarAmps), typeof(ResCategory))] GuitarAmps = 3,
    }

    /// <summary>
    /// Defines the PianosAndKeyboards.
    /// </summary>
    public enum PianosAndKeyboards
    {
        /// <summary>
        /// Defines the AcousticGuitars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ElectronicKeyboards), typeof(ResCategory))] AcousticGuitars = 0,

        /// <summary>
        /// Defines the BassGuitars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Pianos), typeof(ResCategory))] BassGuitars = 1,
    }

    /// <summary>
    /// Defines the BrassInstrumentsCategory.
    /// </summary>
    public enum BrassInstrumentsCategory
    {
        /// <summary>
        /// Defines the Trumpets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Trumpets), typeof(ResCategory))] Trumpets = 0,
    }

    /// <summary>
    /// Defines the MensCategory.
    /// </summary>
    public enum MensCategory
    {
        /// <summary>
        /// Defines the MensClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MensClothing), typeof(ResCategory))]
        MensClothing = 0,

        /// <summary>
        /// Defines the MensShoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MensShoes), typeof(ResCategory))]
        MensShoes = 1,
    }

    /// <summary>
    /// Defines the ShoesCategory.
    /// </summary>
    public enum ShoesCategory
    {
        /// <summary>
        /// Defines the BoysShoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BoysShoes), typeof(ResCategory))]
        BoysShoes = 0,

        /// <summary>
        /// Defines the GirlsShoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GirlsShoes), typeof(ResCategory))]
        GirlsShoes = 1,

        /// <summary>
        /// Defines the MensShoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MensShoes), typeof(ResCategory))]
        MensShoes = 2,

        /// <summary>
        /// Defines the WomensShoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WomensShoes), typeof(ResCategory))]
        WomensShoes = 3
    }

    /// <summary>
    /// Defines the WomensCategory.
    /// </summary>
    public enum WomensCategory
    {
        /// <summary>
        /// Defines the WomensClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WomensClothing), typeof(ResCategory))]
        WomensClothing = 0,

        /// <summary>
        /// Defines the WomensShoes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WomensShoes), typeof(ResCategory))]
        WomensShoes = 1,
    }

    /// <summary>
    /// Defines the ClassifiedCategory.
    /// </summary>
    public enum ClassifiedCategory
    {
        /// <summary>
        /// Defines the GarageSale.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GarageSale), typeof(ResCategory))]
        GarageSale = 0,

        /// <summary>
        /// Defines the Miscellaneous.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Miscellaneous), typeof(ResCategory))]
        Miscellaneous = 1,
    }

    /// <summary>
    /// Defines the ElectronicsCategory.
    /// </summary>
    public enum ElectronicsCategory
    {
        /// <summary>
        /// Defines the Cameras.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Cameras), typeof(ResCategory))]
        Cameras = 0,

        /// <summary>
        /// Defines the CarElectronics.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarElectronics), typeof(ResCategory))]
        CarElectronics = 1,

        /// <summary>
        /// Defines the CellPhoneAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CellPhoneAccessories), typeof(ResCategory))]
        CellPhoneAccessories = 2,

        /// <summary>
        /// Defines the CellPhones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CellPhones), typeof(ResCategory))]
        CellPhones = 3,

        /// <summary>
        /// Defines the Computers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Computers), typeof(ResCategory))]
        Computers = 4,

        /// <summary>
        /// Defines the Headphones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Headphones), typeof(ResCategory))]
        Headphones = 5,

        /// <summary>
        /// Defines the HomeAudioAndVideoSystems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeAudioAndVideoSystems), typeof(ResCategory))]
        HomeAudioAndVideoSystems = 6,

        /// <summary>
        /// Defines the HomeAutomationSystems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeAutomationSystems), typeof(ResCategory))]
        HomeAutomationSystems = 7,

        /// <summary>
        /// Defines the PortableAudioAndVideo.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PortableAudioAndVideo), typeof(ResCategory))]
        PortableAudioAndVideo = 8,

        /// <summary>
        /// Defines the Printers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Printers), typeof(ResCategory))]
        Printers = 9,

        /// <summary>
        /// Defines the SecurityCameras.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SecurityCameras), typeof(ResCategory))]
        SecurityCameras = 10,

        /// <summary>
        /// Defines the TVs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TVs), typeof(ResCategory))]
        TVs = 11,

        /// <summary>
        /// Defines the VideoGameConsoles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VideoGameConsoles), typeof(ResCategory))]
        VideoGameConsoles = 12
    }

    /// <summary>
    /// Defines the CamerasCategory.
    /// </summary>
    public enum CamerasCategory
    {
        /// <summary>
        /// Defines the CameraBagsAndCases.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CameraBagsAndCases), typeof(ResCategory))]
        CameraBagsAndCases = 0,

        /// <summary>
        /// Defines the CameraDrones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CameraDrones), typeof(ResCategory))]
        CameraDrones = 1,

        /// <summary>
        /// Defines the CameraLenses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CameraLenses), typeof(ResCategory))]
        CameraLenses = 2,

        /// <summary>
        /// Defines the DigitalCameras.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DigitalCameras), typeof(ResCategory))]
        DigitalCameras = 3,

        /// <summary>
        /// Defines the Telescopes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Telescopes), typeof(ResCategory))]
        Telescopes = 4,

        /// <summary>
        /// Defines the Tripods.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Tripods), typeof(ResCategory))]
        Tripods = 5
    }

    /// <summary>
    /// Defines the CarElectronicsCategory.
    /// </summary>
    public enum CarElectronicsCategory
    {
        /// <summary>
        /// Defines the CarAudio.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarAudio), typeof(ResCategory))]
        CarAudio = 0,

        /// <summary>
        /// Defines the CarSpeakers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarSpeakers), typeof(ResCategory))]
        CarSpeakers = 1,

        /// <summary>
        /// Defines the CarSubwoofers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarSubwoofers), typeof(ResCategory))]
        CarSubwoofers = 2,

        /// <summary>
        /// Defines the GPSSystems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GPSSystems), typeof(ResCategory))]
        GPSSystems = 3
    }

    /// <summary>
    /// Defines the CellPhoneAccessoriesCategory.
    /// </summary>
    public enum CellPhoneAccessoriesCategory
    {
        /// <summary>
        /// Defines the CellPhoneCases.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CellPhoneCases), typeof(ResCategory))]
        CellPhoneCases = 0,

        /// <summary>
        /// Defines the CellPhoneMemoryCards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CellPhoneMemoryCards), typeof(ResCategory))]
        CellPhoneMemoryCards = 1,

        /// <summary>
        /// Defines the SmartWatches.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SmartWatches), typeof(ResCategory))]
        SmartWatches = 2
    }

    /// <summary>
    /// Defines the CellPhonesCategory.
    /// </summary>
    public enum CellPhonesCategory
    {
        /// <summary>
        /// Defines the CellPhoneAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CellPhoneAccessories), typeof(ResCategory))]
        CellPhoneAccessories = 0,

        /// <summary>
        /// Defines the GooglePixel.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GooglePixel), typeof(ResCategory))]
        GooglePixel = 1,

        /// <summary>
        /// Defines the LGPhones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LGPhones), typeof(ResCategory))]
        LGPhones = 2,

        /// <summary>
        /// Defines the SamsungPhones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SamsungPhones), typeof(ResCategory))]
        SamsungPhones = 3,

        /// <summary>
        /// Defines the iPhones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.iPhones), typeof(ResCategory))]
        iPhones = 4
    }

    /// <summary>
    /// Defines the ComputersCategory.
    /// </summary>
    public enum ComputersCategory
    {
        /// <summary>
        /// Defines the ComputerCables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerCables), typeof(ResCategory))]
        ComputerCables = 0,

        /// <summary>
        /// Defines the ComputerCases.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerCases), typeof(ResCategory))]
        ComputerCases = 1,

        /// <summary>
        /// Defines the ComputerHardDrives.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerHardDrives), typeof(ResCategory))]
        ComputerHardDrives = 2,

        /// <summary>
        /// Defines the ComputerHeadsets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerHeadsets), typeof(ResCategory))]
        ComputerHeadsets = 3,

        /// <summary>
        /// Defines the ComputerKeyboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerKeyboards), typeof(ResCategory))]
        ComputerKeyboards = 4,

        /// <summary>
        /// Defines the ComputerMemoryAndRAM.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerMemoryAndRAM), typeof(ResCategory))]
        ComputerMemoryAndRAM = 5,

        /// <summary>
        /// Defines the ComputerMicrophones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerMicrophones), typeof(ResCategory))]
        ComputerMicrophones = 6,

        /// <summary>
        /// Defines the ComputerSpeakers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerSpeakers), typeof(ResCategory))]
        ComputerSpeakers = 7,

        /// <summary>
        /// Defines the DesktopComputers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DesktopComputers), typeof(ResCategory))]
        DesktopComputers = 8,

        /// <summary>
        /// Defines the HubsAndSwitches.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HubsAndSwitches), typeof(ResCategory))]
        HubsAndSwitches = 9,

        /// <summary>
        /// Defines the Laptops.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Laptops), typeof(ResCategory))]
        Laptops = 10,

        /// <summary>
        /// Defines the ComputerMonitors.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ComputerMonitors), typeof(ResCategory))]
        ComputerMonitors = 11,

        /// <summary>
        /// Defines the RoutersAndModems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RoutersAndModems), typeof(ResCategory))]
        RoutersAndModems = 12,

        /// <summary>
        /// Defines the TabletsAndeBooks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TabletsAndeBooks), typeof(ResCategory))]
        TabletsAndeBooks = 13,

        /// <summary>
        /// Defines the VideoCards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VideoCards), typeof(ResCategory))]
        VideoCards = 14
    }

    /// <summary>
    /// Defines the HomeAudioAndVideoSystemsCategory.
    /// </summary>
    public enum HomeAudioAndVideoSystemsCategory
    {
        /// <summary>
        /// Defines the AntennasAndDishes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AntennasAndDishes), typeof(ResCategory))]
        AntennasAndDishes = 0,

        /// <summary>
        /// Defines the DVDPlayers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DVDPlayers), typeof(ResCategory))]
        DVDPlayers = 1,

        /// <summary>
        /// Defines the HomeSpeakers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeSpeakers), typeof(ResCategory))]
        HomeSpeakers = 2,

        /// <summary>
        /// Defines the HomeTheater.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HomeTheater), typeof(ResCategory))]
        HomeTheater = 3,

        /// <summary>
        /// Defines the MediaStreamers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MediaStreamers), typeof(ResCategory))]
        MediaStreamers = 4,

        /// <summary>
        /// Defines the StereoReceivers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StereoReceivers), typeof(ResCategory))]
        StereoReceivers = 5,

        /// <summary>
        /// Defines the TVs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TVs), typeof(ResCategory))]
        TVs = 6,

        /// <summary>
        /// Defines the TurntablesAndRecordPlayers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TurntablesAndRecordPlayers), typeof(ResCategory))]
        TurntablesAndRecordPlayers = 7
    }

    /// <summary>
    /// Defines the HomeAutomationSystemsCategory.
    /// </summary>
    public enum HomeAutomationSystemsCategory
    {
        /// <summary>
        /// Defines the SmartHomeDevices.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SmartHomeDevices), typeof(ResCategory))]
        SmartHomeDevices = 0
    }

    /// <summary>
    /// Defines the PortableAudioAndVideoCategory.
    /// </summary>
    public enum PortableAudioAndVideoCategory
    {
        /// <summary>
        /// Defines the Boomboxes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Boomboxes), typeof(ResCategory))]
        Boomboxes = 0,

        /// <summary>
        /// Defines the Headphones.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Headphones), typeof(ResCategory))]
        Headphones = 1,

        /// <summary>
        /// Defines the Jukeboxes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Jukeboxes), typeof(ResCategory))]
        Jukeboxes = 2,

        /// <summary>
        /// Defines the KaraokeMachines.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KaraokeMachines), typeof(ResCategory))]
        KaraokeMachines = 3
    }

    /// <summary>
    /// Defines the VideoGamesAndConsolesCategory.
    /// </summary>
    public enum VideoGamesAndConsolesCategory
    {
        /// <summary>
        /// Defines the ArcadeMachines.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ArcadeMachines), typeof(ResCategory))]
        ArcadeMachines = 0,

        /// <summary>
        /// Defines the GamingHeadsets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GamingHeadsets), typeof(ResCategory))]
        GamingHeadsets = 1,

        /// <summary>
        /// Defines the VideoGameConsoles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VideoGameConsoles), typeof(ResCategory))]
        VideoGameConsoles = 2,

        /// <summary>
        /// Defines the VideoGameControllers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VideoGameControllers), typeof(ResCategory))]
        VideoGameControllers = 3,

        /// <summary>
        /// Defines the VideoGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VideoGames), typeof(ResCategory))]
        VideoGames = 4,

        /// <summary>
        /// Defines the VirtualRealityHeadsets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.VirtualRealityHeadsets), typeof(ResCategory))]
        VirtualRealityHeadsets = 5
    }

    /// <summary>
    /// Defines the EntertainmentCategory.
    /// </summary>
    public enum EntertainmentCategory
    {
        /// <summary>
        /// Defines the BooksMoviesAndMusic.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BooksMoviesAndMusic), typeof(ResCategory))]
        BooksMoviesAndMusic = 0
    }

    /// <summary>
    /// Defines the FamilyCategory.
    /// </summary>
    public enum FamilyCategory
    {
        /// <summary>
        /// Defines the BabyAndKidsItems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyAndKidsItems), typeof(ResCategory))]
        BabyAndKidsItems = 0,

        /// <summary>
        /// Defines the HealthAndBeauty.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HealthAndBeauty), typeof(ResCategory))]
        HealthAndBeauty = 1,

        /// <summary>
        /// Defines the PetSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PetSupplies), typeof(ResCategory))]
        PetSupplies = 2,

        /// <summary>
        /// Defines the ToysAndGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToysAndGames), typeof(ResCategory))]
        ToysAndGames = 3
    }

    /// <summary>
    /// Defines the BabyAndKidsItemsCategory.
    /// </summary>
    public enum BabyAndKidsItemsCategory
    {
        /// <summary>
        /// Defines the BabyAndToddlerFeedingSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyAndToddlerFeedingSupplies), typeof(ResCategory))]
        BabyAndToddlerFeedingSupplies = 0,

        /// <summary>
        /// Defines the BabyBathingSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyBathingSupplies), typeof(ResCategory))]
        BabyBathingSupplies = 1,

        /// <summary>
        /// Defines the BabyCarriers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyCarriers), typeof(ResCategory))]
        BabyCarriers = 2,

        /// <summary>
        /// Defines the BabyDiaperingItems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyDiaperingItems), typeof(ResCategory))]
        BabyDiaperingItems = 3,

        /// <summary>
        /// Defines the BabyGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyGear), typeof(ResCategory))]
        BabyGear = 4,

        /// <summary>
        /// Defines the BabySafetyAndHealth.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabySafetyAndHealth), typeof(ResCategory))]
        BabySafetyAndHealth = 5,

        /// <summary>
        /// Defines the BabyStrollers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyStrollers), typeof(ResCategory))]
        BabyStrollers = 6,

        /// <summary>
        /// Defines the BabyToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BabyToys), typeof(ResCategory))]
        BabyToys = 7,

        /// <summary>
        /// Defines the CarSeatsAndAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarSeatsAndAccessories), typeof(ResCategory))]
        CarSeatsAndAccessories = 8,

        /// <summary>
        /// Defines the NurseryBedding.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.NurseryBedding), typeof(ResCategory))]
        NurseryBedding = 9,

        /// <summary>
        /// Defines the NurseryDecor.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.NurseryDecor), typeof(ResCategory))]
        NurseryDecor = 10,

        /// <summary>
        /// Defines the PottyTrainingItems.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PottyTrainingItems), typeof(ResCategory))]
        PottyTrainingItems = 11
    }

    /// <summary>
    /// Defines the HealthAndBeautyCategory.
    /// </summary>
    public enum HealthAndBeautyCategory
    {
        /// <summary>
        /// Defines the BeautyProducts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BeautyProducts), typeof(ResCategory))]
        BeautyProducts = 0,

        /// <summary>
        /// Defines the HealthCareProducts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HealthCareProducts), typeof(ResCategory))]
        HealthCareProducts = 1,

        /// <summary>
        /// Defines the PersonalCareProducts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PersonalCareProducts), typeof(ResCategory))]
        PersonalCareProducts = 2
    }

    /// <summary>
    /// Defines the PetSuppliesCategory.
    /// </summary>
    public enum PetSuppliesCategory
    {
        /// <summary>
        /// Defines the BirdSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BirdSupplies), typeof(ResCategory))]
        BirdSupplies = 0,

        /// <summary>
        /// Defines the CatSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CatSupplies), typeof(ResCategory))]
        CatSupplies = 1,

        /// <summary>
        /// Defines the ChickenSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChickenSupplies), typeof(ResCategory))]
        ChickenSupplies = 2,

        /// <summary>
        /// Defines the DogSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DogSupplies), typeof(ResCategory))]
        DogSupplies = 3,

        /// <summary>
        /// Defines the FishSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FishSupplies), typeof(ResCategory))]
        FishSupplies = 4,

        /// <summary>
        /// Defines the PetCrates.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PetCrates), typeof(ResCategory))]
        PetCrates = 5,

        /// <summary>
        /// Defines the PetKennels.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PetKennels), typeof(ResCategory))]
        PetKennels = 6,

        /// <summary>
        /// Defines the ReptileSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ReptileSupplies), typeof(ResCategory))]
        ReptileSupplies = 7
    }

    /// <summary>
    /// Defines the BirdSuppliesCategory.
    /// </summary>
    public enum BirdSuppliesCategory
    {
        /// <summary>
        /// Defines the BirdCages.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BirdCages), typeof(ResCategory))]
        BirdCages = 0,

        /// <summary>
        /// Defines the BirdPerches.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BirdPerches), typeof(ResCategory))]
        BirdPerches = 1,
    }

    /// <summary>
    /// Defines the CatSuppliesCategory.
    /// </summary>
    public enum CatSuppliesCategory
    {
        /// <summary>
        /// Defines the CatScratchers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CatScratchers), typeof(ResCategory))]
        CatScratchers = 0,

        /// <summary>
        /// Defines the CatToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CatToys), typeof(ResCategory))]
        CatToys = 1,

        /// <summary>
        /// Defines the CatTrees.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CatTrees), typeof(ResCategory))]
        CatTrees = 2,

        /// <summary>
        /// Defines the LitterBoxes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LitterBoxes), typeof(ResCategory))]
        LitterBoxes = 3
    }

    /// <summary>
    /// Defines the ChickenSuppliesCategory.
    /// </summary>
    public enum ChickenSuppliesCategory
    {
        /// <summary>
        /// Defines the ChickenCoops.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChickenCoops), typeof(ResCategory))]
        ChickenCoops = 0,

        /// <summary>
        /// Defines the ChickenFeeders.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChickenFeeders), typeof(ResCategory))]
        ChickenFeeders = 1
    }

    /// <summary>
    /// Defines the DogSuppliesCategory.
    /// </summary>
    public enum DogSuppliesCategory
    {
        /// <summary>
        /// Defines the DogHouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DogHouses), typeof(ResCategory))]
        DogHouses = 0,

        /// <summary>
        /// Defines the DogToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DogToys), typeof(ResCategory))]
        DogToys = 1,
    }

    /// <summary>
    /// Defines the FishSuppliesCategory.
    /// </summary>
    public enum FishSuppliesCategory
    {
        /// <summary>
        /// Defines the AquariumDecorations.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AquariumDecorations), typeof(ResCategory))]
        AquariumDecorations = 0,

        /// <summary>
        /// Defines the AquariumFilters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AquariumFilters), typeof(ResCategory))]
        AquariumFilters = 1,

        /// <summary>
        /// Defines the FishAquariums.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FishAquariums), typeof(ResCategory))]
        FishAquariums = 2
    }

    /// <summary>
    /// Defines the ReptileSuppliesCategory.
    /// </summary>
    public enum ReptileSuppliesCategory
    {
        /// <summary>
        /// Defines the ReptileCages.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ReptileCages), typeof(ResCategory))]
        ReptileCages = 0
    }

    /// <summary>
    /// Defines the SportingGoodsCategory.
    /// </summary>
    public enum SportingGoodsCategory
    {
        /// <summary>
        /// Defines the Bicycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Bicycles), typeof(ResCategory))]
        Bicycles = 0,

        /// <summary>
        /// Defines the ExerciseAndFitnessEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ExerciseAndFitnessEquipment), typeof(ResCategory))]
        ExerciseAndFitnessEquipment = 1,

        /// <summary>
        /// Defines the IndoorGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.IndoorGames), typeof(ResCategory))]
        IndoorGames = 2,

        /// <summary>
        /// Defines the Kayaks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Kayaks), typeof(ResCategory))]
        Kayaks = 3,

        /// <summary>
        /// Defines the OutdoorGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorGames), typeof(ResCategory))]
        OutdoorGames = 4,

        /// <summary>
        /// Defines the OutdoorRecreationEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorRecreationEquipment), typeof(ResCategory))]
        OutdoorRecreationEquipment = 5,

        /// <summary>
        /// Defines the SportsEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SportsEquipment), typeof(ResCategory))]
        SportsEquipment = 6
    }

    /// <summary>
    /// Defines the ExerciseAndFitnessEquipmentCategory.
    /// </summary>
    public enum ExerciseAndFitnessEquipmentCategory
    {
        /// <summary>
        /// Defines the AbMachines.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AbMachines), typeof(ResCategory))]
        AbMachines = 0,
    }

    /// <summary>
    /// Defines the IndoorGamesCategory.
    /// </summary>
    public enum IndoorGamesCategory
    {
        /// <summary>
        /// Defines the AirHockey.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirHockey), typeof(ResCategory))]
        AirHockey = 0,

        /// <summary>
        /// Defines the BowlingAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BowlingAccessories), typeof(ResCategory))]
        BowlingAccessories = 1,

        /// <summary>
        /// Defines the Dartboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Dartboards), typeof(ResCategory))]
        Dartboards = 2,

        /// <summary>
        /// Defines the FoosballTables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FoosballTables), typeof(ResCategory))]
        FoosballTables = 3,

        /// <summary>
        /// Defines the PingPongEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PingPongEquipment), typeof(ResCategory))]
        PingPongEquipment = 4,

        /// <summary>
        /// Defines the PoolCues.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PoolCues), typeof(ResCategory))]
        PoolCues = 5,

        /// <summary>
        /// Defines the PoolTables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PoolTables), typeof(ResCategory))]
        PoolTables = 6
    }

    /// <summary>
    /// Defines the OutdoorGamesCategory.
    /// </summary>
    public enum OutdoorGamesCategory
    {
        /// <summary>
        /// Defines the DiscGolfEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DiscGolfEquipment), typeof(ResCategory))]
        DiscGolfEquipment = 0,

        /// <summary>
        /// Defines the LawnGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LawnGames), typeof(ResCategory))]
        LawnGames = 1,

        /// <summary>
        /// Defines the OutdoorToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorToys), typeof(ResCategory))]
        OutdoorToys = 2
    }

    /// <summary>
    /// Defines the OutdoorRecreationEquipmentCategory.
    /// </summary>
    public enum OutdoorRecreationEquipmentCategory
    {
        /// <summary>
        /// Defines the AirsoftEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirsoftEquipment), typeof(ResCategory))]
        AirsoftEquipment = 0,

        /// <summary>
        /// Defines the CampingAndHikingEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CampingAndHikingEquipment), typeof(ResCategory))]
        CampingAndHikingEquipment = 1,

        /// <summary>
        /// Defines the EquestrianEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.EquestrianEquipment), typeof(ResCategory))]
        EquestrianEquipment = 2,

        /// <summary>
        /// Defines the FishingGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FishingGear), typeof(ResCategory))]
        FishingGear = 3,

        /// <summary>
        /// Defines the RollerSkatingGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RollerSkatingGear), typeof(ResCategory))]
        RollerSkatingGear = 4,

        /// <summary>
        /// Defines the SkateboardingGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SkateboardingGear), typeof(ResCategory))]
        SkateboardingGear = 5,

        /// <summary>
        /// Defines the WaterSportsAndBoatingEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WaterSportsAndBoatingEquipment), typeof(ResCategory))]
        WaterSportsAndBoatingEquipment = 6,

        /// <summary>
        /// Defines the WinterSportsEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WinterSportsEquipment), typeof(ResCategory))]
        WinterSportsEquipment = 7
    }

    /// <summary>
    /// Defines the SportsEquipmentCategory.
    /// </summary>
    public enum SportsEquipmentCategory
    {
        /// <summary>
        /// Defines the BaseballGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BaseballGear), typeof(ResCategory))]
        BaseballGear = 0,

        /// <summary>
        /// Defines the BasketballGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BasketballGear), typeof(ResCategory))]
        BasketballGear = 1,

        /// <summary>
        /// Defines the FootballGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FootballGear), typeof(ResCategory))]
        FootballGear = 2,

        /// <summary>
        /// Defines the GolfEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GolfEquipment), typeof(ResCategory))]
        GolfEquipment = 3,

        /// <summary>
        /// Defines the GymnasticsEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GymnasticsEquipment), typeof(ResCategory))]
        GymnasticsEquipment = 4,

        /// <summary>
        /// Defines the HockeyEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HockeyEquipment), typeof(ResCategory))]
        HockeyEquipment = 5,

        /// <summary>
        /// Defines the LacrosseGear.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LacrosseGear), typeof(ResCategory))]
        LacrosseGear = 6,

        /// <summary>
        /// Defines the TennisEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TennisEquipment), typeof(ResCategory))]
        TennisEquipment = 7
    }

    /// <summary>
    /// Defines the ToysAndGamesCategory.
    /// </summary>
    public enum ToysAndGamesCategory
    {
        /// <summary>
        /// Defines the ActionFigures.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ActionFigures), typeof(ResCategory))]
        ActionFigures = 0,

        /// <summary>
        /// Defines the BuildingToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BuildingToys), typeof(ResCategory))]
        BuildingToys = 1,

        /// <summary>
        /// Defines the Dollhouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Dollhouses), typeof(ResCategory))]
        Dollhouses = 2,

        /// <summary>
        /// Defines the Dolls.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Dolls), typeof(ResCategory))]
        Dolls = 3,

        /// <summary>
        /// Defines the EducationalToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.EducationalToys), typeof(ResCategory))]
        EducationalToys = 4,

        /// <summary>
        /// Defines the Games.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Games), typeof(ResCategory))]
        Games = 5,

        /// <summary>
        /// Defines the ModelKits.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ModelKits), typeof(ResCategory))]
        ModelKits = 6,

        /// <summary>
        /// Defines the OutdoorToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorToys), typeof(ResCategory))]
        OutdoorToys = 7,

        /// <summary>
        /// Defines the IndoorAndOutdoorKidsPlayhouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.IndoorAndOutdoorKidsPlayhouses), typeof(ResCategory))]
        IndoorAndOutdoorKidsPlayhouses = 8,

        /// <summary>
        /// Defines the PlayKitchens.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PlayKitchens), typeof(ResCategory))]
        PlayKitchens = 9,

        /// <summary>
        /// Defines the Puzzles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Puzzles), typeof(ResCategory))]
        Puzzles = 10,

        /// <summary>
        /// Defines the RemoteControlToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RemoteControlToys), typeof(ResCategory))]
        RemoteControlToys = 11,

        /// <summary>
        /// Defines the StuffedAnimals.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StuffedAnimals), typeof(ResCategory))]
        StuffedAnimals = 12,

        /// <summary>
        /// Defines the ToyVehicles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToyVehicles), typeof(ResCategory))]
        ToyVehicles = 13
    }

    /// <summary>
    /// Defines the EducationalToysCategory.
    /// </summary>
    public enum EducationalToysCategory
    {
        /// <summary>
        /// Defines the MathToys.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MathToys), typeof(ResCategory))]
        MathToys = 0
    }

    /// <summary>
    /// Defines the GamesCategory.
    /// </summary>
    public enum GamesCategory
    {
        /// <summary>
        /// Defines the AirHockey.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AirHockey), typeof(ResCategory))]
        AirHockey = 0,

        /// <summary>
        /// Defines the BoardGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BoardGames), typeof(ResCategory))]
        BoardGames = 1,

        /// <summary>
        /// Defines the BowlingAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BowlingAccessories), typeof(ResCategory))]
        BowlingAccessories = 2,

        /// <summary>
        /// Defines the CardGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CardGames), typeof(ResCategory))]
        CardGames = 3,

        /// <summary>
        /// Defines the ChessSets.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChessSets), typeof(ResCategory))]
        ChessSets = 4,

        /// <summary>
        /// Defines the Dartboards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Dartboards), typeof(ResCategory))]
        Dartboards = 5,

        /// <summary>
        /// Defines the DiceGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DiceGames), typeof(ResCategory))]
        DiceGames = 6,

        /// <summary>
        /// Defines the FoosballTables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FoosballTables), typeof(ResCategory))]
        FoosballTables = 7,

        /// <summary>
        /// Defines the PingPongEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PingPongEquipment), typeof(ResCategory))]
        PingPongEquipment = 8,

        /// <summary>
        /// Defines the PokerChips.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PokerChips), typeof(ResCategory))]
        PokerChips = 9,

        /// <summary>
        /// Defines the PoolTables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PoolTables), typeof(ResCategory))]
        PoolTables = 10,

        /// <summary>
        /// Defines the TradingCards.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TradingCards), typeof(ResCategory))]
        TradingCards = 11,

        /// <summary>
        /// Defines the WarBoardGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WarBoardGames), typeof(ResCategory))]
        WarBoardGames = 12
    }

    /// <summary>
    /// Defines the OutdoorToysCategory.
    /// </summary>
    public enum OutdoorToysCategory
    {
        /// <summary>
        /// Defines the BackyardPlaygrounds.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BackyardPlaygrounds), typeof(ResCategory))]
        BackyardPlaygrounds = 0,

        /// <summary>
        /// Defines the BallPits.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BallPits), typeof(ResCategory))]
        BallPits = 1,

        /// <summary>
        /// Defines the DartGuns.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DartGuns), typeof(ResCategory))]
        DartGuns = 2,

        /// <summary>
        /// Defines the HulaHoops.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HulaHoops), typeof(ResCategory))]
        HulaHoops = 3,

        /// <summary>
        /// Defines the InflatableBouncers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.InflatableBouncers), typeof(ResCategory))]
        InflatableBouncers = 4,

        /// <summary>
        /// Defines the KiddiePools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KiddiePools), typeof(ResCategory))]
        KiddiePools = 5,

        /// <summary>
        /// Defines the Kites.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Kites), typeof(ResCategory))]
        Kites = 6,

        /// <summary>
        /// Defines the OutdoorGames.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorGames), typeof(ResCategory))]
        OutdoorGames = 7,

        /// <summary>
        /// Defines the PogoSticks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PogoSticks), typeof(ResCategory))]
        PogoSticks = 8,

        /// <summary>
        /// Defines the WaterTables.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WaterTables), typeof(ResCategory))]
        WaterTables = 9,

        /// <summary>
        /// Defines the Trampolines.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Trampolines), typeof(ResCategory))]
        Trampolines = 10
    }

    /// <summary>
    /// Defines the GardenAndOutdoorCategory.
    /// </summary>
    public enum GardenAndOutdoorCategory
    {
        /// <summary>
        /// Defines the BirdAndWildlifeAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BirdAndWildlifeAccessories), typeof(ResCategory))] BirdAndWildlifeAccessories = 0,

        /// <summary>
        /// Defines the FencingSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FencingSupplies), typeof(ResCategory))] FencingSupplies = 1,

        /// <summary>
        /// Defines the GardenDecor.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GardenDecor), typeof(ResCategory))] GardenDecor = 2,

        /// <summary>
        /// Defines the GardenStructures.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GardenStructures), typeof(ResCategory))] GardenStructures = 3,

        /// <summary>
        /// Defines the GardeningSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GardeningSupplies), typeof(ResCategory))] GardeningSupplies = 4,

        /// <summary>
        /// Defines the LawnMowers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LawnMowers), typeof(ResCategory))] LawnMowers = 5,

        /// <summary>
        /// Defines the OutdoorCooking.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorCooking), typeof(ResCategory))] OutdoorCooking = 6,

        /// <summary>
        /// Defines the OutdoorLighting.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorLighting), typeof(ResCategory))] OutdoorLighting = 7,

        /// <summary>
        /// Defines the OutdoorPowerEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OutdoorPowerEquipment), typeof(ResCategory))] OutdoorPowerEquipment = 8,

        /// <summary>
        /// Defines the PatioFurniture.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PatioFurniture), typeof(ResCategory))] PatioFurniture = 9,

        /// <summary>
        /// Defines the PoolsAndSpas.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PoolsAndSpas), typeof(ResCategory))] PoolsAndSpas = 10,

        /// <summary>
        /// Defines the PowerTools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PowerTools), typeof(ResCategory))] PowerTools = 11,
    }

    /// <summary>
    /// Defines the GardenStructuresCategory.
    /// </summary>
    public enum GardenStructuresCategory
    {
        /// <summary>
        /// Defines the Arbors.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Arbors), typeof(ResCategory))] Arbors = 0,

        /// <summary>
        /// Defines the Gazebos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Gazebos), typeof(ResCategory))] Gazebos = 1,

        /// <summary>
        /// Defines the StorageSheds.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StorageSheds), typeof(ResCategory))] StorageSheds = 2,

        /// <summary>
        /// Defines the PatioUmbrellas.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PatioUmbrellas), typeof(ResCategory))] PatioUmbrellas = 3
    }

    /// <summary>
    /// Defines the GardeningSuppliesCategory.
    /// </summary>
    public enum GardeningSuppliesCategory
    {
        /// <summary>
        /// Defines the Composters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Composters), typeof(ResCategory))] Composters = 0,

        /// <summary>
        /// Defines the GardenTools.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GardenTools), typeof(ResCategory))] GardenTools = 1,

        /// <summary>
        /// Defines the HydroponicSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HydroponicSupplies), typeof(ResCategory))] HydroponicSupplies = 2,

        /// <summary>
        /// Defines the LandscapingMaterials.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LandscapingMaterials), typeof(ResCategory))] LandscapingMaterials = 3,

        /// <summary>
        /// Defines the PlantSupplies.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PlantSupplies), typeof(ResCategory))] PlantSupplies = 4,

        /// <summary>
        /// Defines the PlantsSeedsAndBulbs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PlantsSeedsAndBulbs), typeof(ResCategory))] PlantsSeedsAndBulbs = 5,

        /// <summary>
        /// Defines the WateringEquipment.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.WateringEquipment), typeof(ResCategory))] WateringEquipment = 6,
    }

    /// <summary>
    /// Defines the RemoteControlToysCategory.
    /// </summary>
    public enum RemoteControlToysCategory
    {
        /// <summary>
        /// Defines the RemoteToyCarsAndTrucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RemoteToyCarsAndTrucks), typeof(ResCategory))]
        RemoteToyCarsAndTrucks = 0
    }

    /// <summary>
    /// Defines the ToyVehiclesCategory.
    /// </summary>
    public enum ToyVehiclesCategory
    {
        /// <summary>
        /// Defines the ToyAirplanes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToyAirplanes), typeof(ResCategory))]
        ToyAirplanes = 0,

        /// <summary>
        /// Defines the ToyBoats.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToyBoats), typeof(ResCategory))]
        ToyBoats = 1,

        /// <summary>
        /// Defines the ToyCars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToyCars), typeof(ResCategory))]
        ToyCars = 2,

        /// <summary>
        /// Defines the ToyConstructionVehicles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToyConstructionVehicles), typeof(ResCategory))]
        ToyConstructionVehicles = 3
    }
}
