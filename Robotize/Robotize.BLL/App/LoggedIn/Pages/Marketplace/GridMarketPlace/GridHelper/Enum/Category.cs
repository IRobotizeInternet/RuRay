using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum ApparelCategory
    {
        [LocalizedDescription(nameof(ResCategory.Womens), typeof(ResCategory))]
        Womens = 0,
        [LocalizedDescription(nameof(ResCategory.Mens), typeof(ResCategory))]
        Mens = 1,
        [LocalizedDescription(nameof(ResCategory.KidsClothing), typeof(ResCategory))]
        KidsClothing = 2,
        [LocalizedDescription(nameof(ResCategory.BabyClothing), typeof(ResCategory))]
        BabyClothing = 3,
        [LocalizedDescription(nameof(ResCategory.Shoes), typeof(ResCategory))]
        Shoes = 4,
        [LocalizedDescription(nameof(ResCategory.JewelryAndAccessories), typeof(ResCategory))]
        JewelryAndAccessories = 5,
        [LocalizedDescription(nameof(ResCategory.BagsAndLuggage), typeof(ResCategory))]
        BagsAndLuggage = 6,
        [LocalizedDescription(nameof(ResCategory.HalloweenAndKidsCostumes), typeof(ResCategory))]
        HalloweenAndKidsCostumes = 7,
        [LocalizedDescription(nameof(ResCategory.UniformsAndWorkClothing), typeof(ResCategory))]
        UniformsAndWorkClothing = 8
    }

    public enum BathProductsCategory
    {
        [LocalizedDescription(nameof(ResCategory.BathLinens), typeof(ResCategory))] BathLinens = 0,
        [LocalizedDescription(nameof(ResCategory.BathroomScales), typeof(ResCategory))] BathroomScales = 1,
        [LocalizedDescription(nameof(ResCategory.MedicineCabinets), typeof(ResCategory))] MedicineCabinets = 2,
        [LocalizedDescription(nameof(ResCategory.ShowerHeads), typeof(ResCategory))] ShowerHeads = 3,
    }
    
    public enum BicyclesCategory
    {
        [LocalizedDescription(nameof(ResCategory.BicycleAccessories), typeof(ResCategory))] BicycleAccessories = 0,
        [LocalizedDescription(nameof(ResCategory.BicycleParts), typeof(ResCategory))] BicycleParts = 1,
    }

    public enum CleaningSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.MopsAndBrooms), typeof(ResCategory))] MopsAndBrooms = 0,
    }


    public enum BeddingCategory
    {
        [LocalizedDescription(nameof(ResCategory.BedSheets), typeof(ResCategory))] BedSheets = 0,
        [LocalizedDescription(nameof(ResCategory.BeddingSets), typeof(ResCategory))] BeddingSets = 1,
        [LocalizedDescription(nameof(ResCategory.BedspreadsAndQuilts), typeof(ResCategory))] BedspreadsAndQuilts = 2,
        [LocalizedDescription(nameof(ResCategory.BlanketsAndThrows), typeof(ResCategory))] BlanketsAndThrows = 3,
        [LocalizedDescription(nameof(ResCategory.Comforters), typeof(ResCategory))] Comforters = 4,
    }

    public enum OfficeFurnitureCategory
    {
        [LocalizedDescription(nameof(ResCategory.Desks), typeof(ResCategory))] Desks = 0,
        [LocalizedDescription(nameof(ResCategory.FilingCabinets), typeof(ResCategory))] FilingCabinets = 1,
        [LocalizedDescription(nameof(ResCategory.OfficeChairs), typeof(ResCategory))] OfficeChairs = 2,
    }

    public enum HomeGoodsCategory
    {
        [LocalizedDescription(nameof(ResCategory.Appliances), typeof(ResCategory))] Appliances = 0,
        [LocalizedDescription(nameof(ResCategory.BathProducts), typeof(ResCategory))] BathProducts = 1,
        [LocalizedDescription(nameof(ResCategory.Bedding), typeof(ResCategory))] Bedding = 2,
        [LocalizedDescription(nameof(ResCategory.CleaningSupplies), typeof(ResCategory))] CleaningSupplies = 3,
        [LocalizedDescription(nameof(ResCategory.Furniture), typeof(ResCategory))] Furniture = 4,
        [LocalizedDescription(nameof(ResCategory.HomeDecor), typeof(ResCategory))] HomeDecor = 5,
        [LocalizedDescription(nameof(ResCategory.HomeImprovementSupplies), typeof(ResCategory))] HomeImprovementSupplies = 6,
        [LocalizedDescription(nameof(ResCategory.HomeLighting), typeof(ResCategory))] HomeLighting = 7,
        [LocalizedDescription(nameof(ResCategory.KitchenAndDiningProducts), typeof(ResCategory))] KitchenAndDiningProducts = 8,
        [LocalizedDescription(nameof(ResCategory.StorageAndOrganization), typeof(ResCategory))] StorageAndOrganization = 9,
        [LocalizedDescription(nameof(ResCategory.Tools), typeof(ResCategory))] Tools = 10,
        [LocalizedDescription(nameof(ResCategory.GardenAndOutdoor), typeof(ResCategory))] GardenAndOutdoor = 11
    }

    public enum HomeDecorCategory
    {
        [LocalizedDescription(nameof(ResCategory.Clocks), typeof(ResCategory))] Clocks = 0,
        [LocalizedDescription(nameof(ResCategory.DecorativeAccents), typeof(ResCategory))] DecorativeAccents = 1,
        [LocalizedDescription(nameof(ResCategory.HolidayDecor), typeof(ResCategory))] HolidayDecor = 2,
        [LocalizedDescription(nameof(ResCategory.HomeFragrances), typeof(ResCategory))] HomeFragrances = 3,
        [LocalizedDescription(nameof(ResCategory.Mirrors), typeof(ResCategory))] Mirrors = 4,
        [LocalizedDescription(nameof(ResCategory.RugsAndCarpets), typeof(ResCategory))] RugsAndCarpets = 5,
    }

    public enum HomeImprovementSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.BathroomVanities), typeof(ResCategory))] BathroomVanities = 0,
        [LocalizedDescription(nameof(ResCategory.Bathtubs), typeof(ResCategory))] Bathtubs = 1,
        [LocalizedDescription(nameof(ResCategory.Countertops), typeof(ResCategory))] Countertops = 2,
        [LocalizedDescription(nameof(ResCategory.Doors), typeof(ResCategory))] Doors = 3,
        [LocalizedDescription(nameof(ResCategory.Gutters), typeof(ResCategory))] Gutters = 4,
        [LocalizedDescription(nameof(ResCategory.HomeHeatingAndCooling), typeof(ResCategory))] HomeHeatingAndCooling = 5,
        [LocalizedDescription(nameof(ResCategory.KitchenCabinets), typeof(ResCategory))] KitchenCabinets = 6,
        [LocalizedDescription(nameof(ResCategory.Mailboxes), typeof(ResCategory))] Mailboxes = 7,
        [LocalizedDescription(nameof(ResCategory.ShowersAndShowerParts), typeof(ResCategory))] ShowersAndShowerParts = 8,
        [LocalizedDescription(nameof(ResCategory.VinylFlooring), typeof(ResCategory))] VinylFlooring = 9,
        [LocalizedDescription(nameof(ResCategory.Tools), typeof(ResCategory))] Tools = 10,
    }

    public enum ShowersAndShowerPartsCategory
    {
        [LocalizedDescription(nameof(ResCategory.ShowerHeads), typeof(ResCategory))] ShowerHeads = 0
    }

    public enum HomeHeatingAndCoolingCategory
    {
        [LocalizedDescription(nameof(ResCategory.AirConditioners), typeof(ResCategory))] AirConditioners = 0,
        [LocalizedDescription(nameof(ResCategory.AirPurifiers), typeof(ResCategory))] AirPurifiers = 1,
        [LocalizedDescription(nameof(ResCategory.Dehumidifiers), typeof(ResCategory))] Dehumidifiers = 2,
        [LocalizedDescription(nameof(ResCategory.Fans), typeof(ResCategory))] Fans = 3,
        [LocalizedDescription(nameof(ResCategory.FireplacesAndStoves), typeof(ResCategory))] FireplacesAndStoves = 4,
        [LocalizedDescription(nameof(ResCategory.Furnaces), typeof(ResCategory))] Furnaces = 5,
        [LocalizedDescription(nameof(ResCategory.Humidifiers), typeof(ResCategory))] Humidifiers = 6,
        [LocalizedDescription(nameof(ResCategory.SpaceHeaters), typeof(ResCategory))] SpaceHeaters = 7,
        [LocalizedDescription(nameof(ResCategory.Thermostats), typeof(ResCategory))] Thermostats = 8,
    }

    public enum HomeLightingCategory
    {
        [LocalizedDescription(nameof(ResCategory.CeilingFans), typeof(ResCategory))] CeilingFans = 0,
        [LocalizedDescription(nameof(ResCategory.Chandeliers), typeof(ResCategory))] Chandeliers = 1,
        [LocalizedDescription(nameof(ResCategory.LampShades), typeof(ResCategory))] LampShades = 2,
        [LocalizedDescription(nameof(ResCategory.Lamps), typeof(ResCategory))] Lamps = 3,
        [LocalizedDescription(nameof(ResCategory.LightBulbs), typeof(ResCategory))] LightBulbs = 4,
        [LocalizedDescription(nameof(ResCategory.NightLights), typeof(ResCategory))] NightLights = 5,
    }

    public enum PianosAndKeyboardsCategory
    {
        [LocalizedDescription(nameof(ResCategory.ElectronicKeyboards), typeof(ResCategory))] ElectronicKeyboards = 0,
        [LocalizedDescription(nameof(ResCategory.Pianos), typeof(ResCategory))] Pianos = 1,
    }

    public enum KitchenAndDiningProductsCategory
    {
        [LocalizedDescription(nameof(ResCategory.BakingPans), typeof(ResCategory))] BakingPans = 0,
        [LocalizedDescription(nameof(ResCategory.Cookware), typeof(ResCategory))] Cookware = 1,
        [LocalizedDescription(nameof(ResCategory.KitchenUtensils), typeof(ResCategory))] KitchenUtensils = 2,
        [LocalizedDescription(nameof(ResCategory.PantryOrganizationAndStorage), typeof(ResCategory))] PantryOrganizationAndStorage = 3,
        [LocalizedDescription(nameof(ResCategory.Tableware), typeof(ResCategory))] Tableware = 4,
        [LocalizedDescription(nameof(ResCategory.VacuumSealers), typeof(ResCategory))] VacuumSealers = 5,
    }

    public enum PatioFurnitureCategory
    {
        [LocalizedDescription(nameof(ResCategory.Hammocks), typeof(ResCategory))] Hammocks = 0,
        [LocalizedDescription(nameof(ResCategory.OutdoorChairs), typeof(ResCategory))] OutdoorChairs = 1,
        [LocalizedDescription(nameof(ResCategory.OutdoorCushions), typeof(ResCategory))] OutdoorCushions = 2,
        [LocalizedDescription(nameof(ResCategory.OutdoorFurnitureSets), typeof(ResCategory))] OutdoorFurnitureSets = 3,
        [LocalizedDescription(nameof(ResCategory.OutdoorHeaters), typeof(ResCategory))] OutdoorHeaters = 4,
        [LocalizedDescription(nameof(ResCategory.OutdoorTables), typeof(ResCategory))] OutdoorTables = 5,
        [LocalizedDescription(nameof(ResCategory.PatioUmbrellas), typeof(ResCategory))] PatioUmbrellas = 6
    }

    public enum StorageAndOrganizationCategory
    {
        [LocalizedDescription(nameof(ResCategory.ClothingStorage), typeof(ResCategory))] ClothingStorage = 0,
        [LocalizedDescription(nameof(ResCategory.GeneralStorage), typeof(ResCategory))] GeneralStorage = 1,
    }

    public enum ToolsCategory
    {
        [LocalizedDescription(nameof(ResCategory.AirTools), typeof(ResCategory))] AirTools = 0,
        [LocalizedDescription(nameof(ResCategory.Anvils), typeof(ResCategory))] Anvils = 1,
        [LocalizedDescription(nameof(ResCategory.HandTools), typeof(ResCategory))] HandTools = 2,
        [LocalizedDescription(nameof(ResCategory.Ladders), typeof(ResCategory))] Ladders = 3,
        [LocalizedDescription(nameof(ResCategory.MeasuringToolsAndSensors), typeof(ResCategory))] MeasuringToolsAndSensors = 4,
        [LocalizedDescription(nameof(ResCategory.ShopVacuums), typeof(ResCategory))] ShopVacuums = 5,
        [LocalizedDescription(nameof(ResCategory.StepStools), typeof(ResCategory))] StepStools = 6,
        [LocalizedDescription(nameof(ResCategory.WorkBenches), typeof(ResCategory))] WorkBenches = 7,
        [LocalizedDescription(nameof(ResCategory.PowerTools), typeof(ResCategory))] PowerTools = 8,
    }

    public enum FurnitureCategory
    {
        [LocalizedDescription(nameof(ResCategory.AccentFurniture), typeof(ResCategory))] AccentFurniture = 0,
        [LocalizedDescription(nameof(ResCategory.BabyFurniture), typeof(ResCategory))] BabyFurniture = 1,
        [LocalizedDescription(nameof(ResCategory.BedroomFurniture), typeof(ResCategory))] BedroomFurniture = 2,
        [LocalizedDescription(nameof(ResCategory.DiningRoomFurniture), typeof(ResCategory))] DiningRoomFurniture = 3,
        [LocalizedDescription(nameof(ResCategory.LivingRoomFurniture), typeof(ResCategory))] LivingRoomFurniture = 4,
        [LocalizedDescription(nameof(ResCategory.PatioFurniture), typeof(ResCategory))] PatioFurniture = 5,
    }

    public enum AppliancesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AirConditioners), typeof(ResCategory))] AirConditioners = 0,
        [LocalizedDescription(nameof(ResCategory.CoffeeMakers), typeof(ResCategory))] CoffeeMakers = 1,
        [LocalizedDescription(nameof(ResCategory.Dishwashers), typeof(ResCategory))] Dishwashers = 2,
        [LocalizedDescription(nameof(ResCategory.ElectricFireplaces), typeof(ResCategory))] ElectricFireplaces = 3,
        [LocalizedDescription(nameof(ResCategory.FoodProcessors), typeof(ResCategory))] FoodProcessors = 4,
        [LocalizedDescription(nameof(ResCategory.KitchenOvens), typeof(ResCategory))] KitchenOvens = 5,
        [LocalizedDescription(nameof(ResCategory.MicrowaveOvens), typeof(ResCategory))] MicrowaveOvens = 6,
        [LocalizedDescription(nameof(ResCategory.MixersAndBlenders), typeof(ResCategory))] MixersAndBlenders = 7,
        [LocalizedDescription(nameof(ResCategory.RefrigeratorsAndFreezers), typeof(ResCategory))] RefrigeratorsAndFreezers = 8,
        [LocalizedDescription(nameof(ResCategory.SteamersAndCookers), typeof(ResCategory))] SteamersAndCookers = 9,
        [LocalizedDescription(nameof(ResCategory.ToasterOvens), typeof(ResCategory))] ToasterOvens = 10,
        [LocalizedDescription(nameof(ResCategory.WaffleMakers), typeof(ResCategory))] WaffleMakers = 11,
        [LocalizedDescription(nameof(ResCategory.WashersAndDryers), typeof(ResCategory))] WashersAndDryers = 12,
    }

    public enum BagsAndLuggageCategory
    {
        [LocalizedDescription(nameof(ResCategory.Backpacks), typeof(ResCategory))]
        Backpacks = 0,
        [LocalizedDescription(nameof(ResCategory.FannyPacks), typeof(ResCategory))]
        FannyPacks = 1,
        [LocalizedDescription(nameof(ResCategory.Luggage), typeof(ResCategory))]
        Luggage = 2,
        [LocalizedDescription(nameof(ResCategory.WomensHandbagsAndPurses), typeof(ResCategory))]
        WomensHandbagsAndPurses = 3
    }

    public enum OfficeSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.BubbleWrap), typeof(ResCategory))] BubbleWrap = 0,
        [LocalizedDescription(nameof(ResCategory.Clipboards), typeof(ResCategory))] Clipboards = 1,
        [LocalizedDescription(nameof(ResCategory.DeskOrganizers), typeof(ResCategory))] DeskOrganizers = 2,
        [LocalizedDescription(nameof(ResCategory.Whiteboards), typeof(ResCategory))] Whiteboards = 3,
        [LocalizedDescription(nameof(ResCategory.OfficeFurniture), typeof(ResCategory))] OfficeFurniture = 4
    }

    public enum OutdoorCookingCategory
    {
        [LocalizedDescription(nameof(ResCategory.BarbecueGrills), typeof(ResCategory))]
        BarbecueGrills = 0,
        [LocalizedDescription(nameof(ResCategory.OutdoorFirePits), typeof(ResCategory))]
        OutdoorFirePits = 1
    }

    public enum OutdoorLightingCategory
    {
        [LocalizedDescription(nameof(ResCategory.LandscapeLights), typeof(ResCategory))]
        LandscapeLights = 0,
        [LocalizedDescription(nameof(ResCategory.StringLights), typeof(ResCategory))]
        StringLights = 1
    }

    public enum HobbiesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AntiquesAndCollectibles), typeof(ResCategory))] AntiquesAndCollectibles = 0,
        [LocalizedDescription(nameof(ResCategory.ArtsAndCrafts), typeof(ResCategory))] ArtsAndCrafts = 1,
        [LocalizedDescription(nameof(ResCategory.AutoParts), typeof(ResCategory))] AutoParts = 2,
        [LocalizedDescription(nameof(ResCategory.Bicycles), typeof(ResCategory))] Bicycles = 3,
        [LocalizedDescription(nameof(ResCategory.FishingGear), typeof(ResCategory))] FishingGear = 4,
        [LocalizedDescription(nameof(ResCategory.MusicalInstruments), typeof(ResCategory))] MusicalInstruments = 5,
        [LocalizedDescription(nameof(ResCategory.OutdoorRecreationEquipment), typeof(ResCategory))] OutdoorRecreationEquipment = 6,
        [LocalizedDescription(nameof(ResCategory.SportingGoods), typeof(ResCategory))] SportingGoods = 7,
        [LocalizedDescription(nameof(ResCategory.ToysAndGames), typeof(ResCategory))] ToysAndGames = 8
    }

    public enum FishingGearCategory
    {
        [LocalizedDescription(nameof(ResCategory.FishingRods), typeof(ResCategory))] FishingRods = 0
    }

    public enum AntiquesAndCollectiblesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AntiqueElectronics), typeof(ResCategory))] AntiqueElectronics = 0,
        [LocalizedDescription(nameof(ResCategory.AntiqueFurniture), typeof(ResCategory))] AntiqueFurniture = 1,
        [LocalizedDescription(nameof(ResCategory.CollectibleStamps), typeof(ResCategory))] CollectibleStamps = 2,
        [LocalizedDescription(nameof(ResCategory.SportsTradingCards), typeof(ResCategory))] SportsTradingCards = 3,
        [LocalizedDescription(nameof(ResCategory.Typewriters), typeof(ResCategory))] Typewriters = 4
    }

    public enum AutoPartsCategory
    {
        [LocalizedDescription(nameof(ResCategory.CarEnginesAndParts), typeof(ResCategory))] CarEnginesAndParts = 0,
        [LocalizedDescription(nameof(ResCategory.CarExhaustsAndParts), typeof(ResCategory))] CarExhaustsAndParts = 1,
        [LocalizedDescription(nameof(ResCategory.CarSuspensionAndSteering), typeof(ResCategory))] CarSuspensionAndSteering = 2,
        [LocalizedDescription(nameof(ResCategory.TiresAndWheels), typeof(ResCategory))] TiresAndWheels = 3
    }

    public enum ArtsAndCraftsCategory
    {
        [LocalizedDescription(nameof(ResCategory.DrawingSupplies), typeof(ResCategory))] DrawingSupplies = 0,
        [LocalizedDescription(nameof(ResCategory.PaintingSupplies), typeof(ResCategory))] PaintingSupplies = 1,
        [LocalizedDescription(nameof(ResCategory.ScrapbookingSupplies), typeof(ResCategory))] ScrapbookingSupplies = 2,
        [LocalizedDescription(nameof(ResCategory.Sewing), typeof(ResCategory))] Sewing = 3,
        [LocalizedDescription(nameof(ResCategory.Yarn), typeof(ResCategory))] Yarn = 4
    }

    public enum PoolsAndSpasCategory
    {
        [LocalizedDescription(nameof(ResCategory.HotTubs), typeof(ResCategory))] HotTubs = 0,
        [LocalizedDescription(nameof(ResCategory.PoolEquipment), typeof(ResCategory))] PoolEquipment = 1,
        [LocalizedDescription(nameof(ResCategory.PoolFloats), typeof(ResCategory))] PoolFloats = 2,
        [LocalizedDescription(nameof(ResCategory.SwimmingPools), typeof(ResCategory))] SwimmingPools = 3,
    }

    public enum PowerToolsCategory
    {
        [LocalizedDescription(nameof(ResCategory.PowerDrills), typeof(ResCategory))] PowerDrills = 0,
        [LocalizedDescription(nameof(ResCategory.Joiners), typeof(ResCategory))] Joiners = 1,
        [LocalizedDescription(nameof(ResCategory.WoodLathes), typeof(ResCategory))] WoodLathes = 2,
        [LocalizedDescription(nameof(ResCategory.NailGuns), typeof(ResCategory))] NailGuns = 3,
        [LocalizedDescription(nameof(ResCategory.Planers), typeof(ResCategory))] Planers = 4,
        [LocalizedDescription(nameof(ResCategory.Sanders), typeof(ResCategory))] Sanders = 5,
        [LocalizedDescription(nameof(ResCategory.Winches), typeof(ResCategory))] Winches = 6,
    }

    public enum OutdoorPowerEquipmentCategory
    {
        [LocalizedDescription(nameof(ResCategory.Chainsaws), typeof(ResCategory))] Chainsaws = 0,
        [LocalizedDescription(nameof(ResCategory.Edgers), typeof(ResCategory))] Edgers = 1,
        [LocalizedDescription(nameof(ResCategory.HedgeTrimmers), typeof(ResCategory))] HedgeTrimmers = 2,
        [LocalizedDescription(nameof(ResCategory.LeafBlowers), typeof(ResCategory))] LeafBlowers = 3,
        [LocalizedDescription(nameof(ResCategory.PressureWashers), typeof(ResCategory))] PressureWashers = 4,
        [LocalizedDescription(nameof(ResCategory.LawnMowers), typeof(ResCategory))] LawnMowers = 5
    }

    public enum JewelryAndAccessoriesCategory
    {
        [LocalizedDescription(nameof(ResCategory.Anklets), typeof(ResCategory))]
        Anklets = 0,
        [LocalizedDescription(nameof(ResCategory.Bracelets), typeof(ResCategory))]
        Bracelets = 1,
        [LocalizedDescription(nameof(ResCategory.CharmsAndPendants), typeof(ResCategory))]
        CharmsAndPendants = 2,
        [LocalizedDescription(nameof(ResCategory.Cufflinks), typeof(ResCategory))]
        Cufflinks = 3,
        [LocalizedDescription(nameof(ResCategory.Earrings), typeof(ResCategory))]
        Earrings = 4,
        [LocalizedDescription(nameof(ResCategory.EngagementJewelry), typeof(ResCategory))]
        EngagementJewelry = 5,
        [LocalizedDescription(nameof(ResCategory.JewelrySets), typeof(ResCategory))]
        JewelrySets = 6,
        [LocalizedDescription(nameof(ResCategory.Necklaces), typeof(ResCategory))]
        Necklaces = 7,
        [LocalizedDescription(nameof(ResCategory.Rings), typeof(ResCategory))]
        Rings = 8,
        [LocalizedDescription(nameof(ResCategory.ScarvesAndBandanas), typeof(ResCategory))]
        ScarvesAndBandanas = 9,
        [LocalizedDescription(nameof(ResCategory.Sunglasses), typeof(ResCategory))]
        Sunglasses = 10,
        [LocalizedDescription(nameof(ResCategory.Wallets), typeof(ResCategory))]
        Wallets = 11,
        [LocalizedDescription(nameof(ResCategory.Watches), typeof(ResCategory))]
        Watches = 12
    }

    public enum MusicalInstrumentsCategory
    {
        [LocalizedDescription(nameof(ResCategory.AudioEquipment), typeof(ResCategory))] AudioEquipment = 0,
        [LocalizedDescription(nameof(ResCategory.BrassInstruments), typeof(ResCategory))] BrassInstruments = 1,
        [LocalizedDescription(nameof(ResCategory.Cellos), typeof(ResCategory))] Cellos = 2,
        [LocalizedDescription(nameof(ResCategory.Clarinets), typeof(ResCategory))] Clarinets = 3,
        [LocalizedDescription(nameof(ResCategory.DrumSets), typeof(ResCategory))] DrumSets = 4,
        [LocalizedDescription(nameof(ResCategory.Flutes), typeof(ResCategory))] Flutes = 5,
        [LocalizedDescription(nameof(ResCategory.GuitarsAndBasses), typeof(ResCategory))] GuitarsAndBasses = 6,
        [LocalizedDescription(nameof(ResCategory.PercussionInstruments), typeof(ResCategory))] PercussionInstruments = 7,
        [LocalizedDescription(nameof(ResCategory.PianosAndKeyboards), typeof(ResCategory))] PianosAndKeyboards = 8,
        [LocalizedDescription(nameof(ResCategory.Saxophones), typeof(ResCategory))] Saxophones = 9,
        [LocalizedDescription(nameof(ResCategory.Ukuleles), typeof(ResCategory))] Ukuleles = 10,
        [LocalizedDescription(nameof(ResCategory.Violas), typeof(ResCategory))] Violas = 11,
        [LocalizedDescription(nameof(ResCategory.Violins), typeof(ResCategory))] Violins = 12,
    }

    public enum AudioEquipmentCategory
    {
        [LocalizedDescription(nameof(ResCategory.AudioInterfaces), typeof(ResCategory))] AudioInterfaces = 0,
    }

    public enum GuitarsAndBassesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AcousticGuitars), typeof(ResCategory))] AcousticGuitars = 0,
        [LocalizedDescription(nameof(ResCategory.BassGuitars), typeof(ResCategory))] BassGuitars = 1,
        [LocalizedDescription(nameof(ResCategory.ElectricGuitars), typeof(ResCategory))] ElectricGuitars = 2,
        [LocalizedDescription(nameof(ResCategory.GuitarAmps), typeof(ResCategory))] GuitarAmps = 3,
    }

    public enum PianosAndKeyboards
    {
        [LocalizedDescription(nameof(ResCategory.ElectronicKeyboards), typeof(ResCategory))] AcousticGuitars = 0,
        [LocalizedDescription(nameof(ResCategory.Pianos), typeof(ResCategory))] BassGuitars = 1,
    }

    public enum BrassInstrumentsCategory
    {
        [LocalizedDescription(nameof(ResCategory.Trumpets), typeof(ResCategory))] Trumpets = 0,
    }

    public enum MensCategory
    {
        [LocalizedDescription(nameof(ResCategory.MensClothing), typeof(ResCategory))]
        MensClothing = 0,
        [LocalizedDescription(nameof(ResCategory.MensShoes), typeof(ResCategory))]
        MensShoes = 1,
    }

    public enum ShoesCategory
    {
        [LocalizedDescription(nameof(ResCategory.BoysShoes), typeof(ResCategory))]
        BoysShoes = 0,
        [LocalizedDescription(nameof(ResCategory.GirlsShoes), typeof(ResCategory))]
        GirlsShoes = 1,
        [LocalizedDescription(nameof(ResCategory.MensShoes), typeof(ResCategory))]
        MensShoes = 2,
        [LocalizedDescription(nameof(ResCategory.WomensShoes), typeof(ResCategory))]
        WomensShoes = 3
    }

    public enum WomensCategory
    {
        [LocalizedDescription(nameof(ResCategory.WomensClothing), typeof(ResCategory))]
        WomensClothing = 0,
        [LocalizedDescription(nameof(ResCategory.WomensShoes), typeof(ResCategory))]
        WomensShoes = 1,
    }

    public enum ClassifiedCategory
    {
        [LocalizedDescription(nameof(ResCategory.GarageSale), typeof(ResCategory))]
        GarageSale = 0,
        [LocalizedDescription(nameof(ResCategory.Miscellaneous), typeof(ResCategory))]
        Miscellaneous = 1,
    }

    public enum ElectronicsCategory
    {
        [LocalizedDescription(nameof(ResCategory.Cameras), typeof(ResCategory))]
        Cameras = 0,
        [LocalizedDescription(nameof(ResCategory.CarElectronics), typeof(ResCategory))]
        CarElectronics = 1,
        [LocalizedDescription(nameof(ResCategory.CellPhoneAccessories), typeof(ResCategory))]
        CellPhoneAccessories = 2,
        [LocalizedDescription(nameof(ResCategory.CellPhones), typeof(ResCategory))]
        CellPhones = 3,
        [LocalizedDescription(nameof(ResCategory.Computers), typeof(ResCategory))]
        Computers = 4,
        [LocalizedDescription(nameof(ResCategory.Headphones), typeof(ResCategory))]
        Headphones = 5,
        [LocalizedDescription(nameof(ResCategory.HomeAudioAndVideoSystems), typeof(ResCategory))]
        HomeAudioAndVideoSystems = 6,
        [LocalizedDescription(nameof(ResCategory.HomeAutomationSystems), typeof(ResCategory))]
        HomeAutomationSystems = 7,
        [LocalizedDescription(nameof(ResCategory.PortableAudioAndVideo), typeof(ResCategory))]
        PortableAudioAndVideo = 8,
        [LocalizedDescription(nameof(ResCategory.Printers), typeof(ResCategory))]
        Printers = 9,
        [LocalizedDescription(nameof(ResCategory.SecurityCameras), typeof(ResCategory))]
        SecurityCameras = 10,
        [LocalizedDescription(nameof(ResCategory.TVs), typeof(ResCategory))]
        TVs = 11,
        [LocalizedDescription(nameof(ResCategory.VideoGameConsoles), typeof(ResCategory))]
        VideoGameConsoles = 12
    }

    public enum CamerasCategory
    {
        [LocalizedDescription(nameof(ResCategory.CameraBagsAndCases), typeof(ResCategory))]
        CameraBagsAndCases = 0,
        [LocalizedDescription(nameof(ResCategory.CameraDrones), typeof(ResCategory))]
        CameraDrones = 1,
        [LocalizedDescription(nameof(ResCategory.CameraLenses), typeof(ResCategory))]
        CameraLenses = 2,
        [LocalizedDescription(nameof(ResCategory.DigitalCameras), typeof(ResCategory))]
        DigitalCameras = 3,
        [LocalizedDescription(nameof(ResCategory.Telescopes), typeof(ResCategory))]
        Telescopes = 4,
        [LocalizedDescription(nameof(ResCategory.Tripods), typeof(ResCategory))]
        Tripods = 5
    }

    public enum CarElectronicsCategory
    {
        [LocalizedDescription(nameof(ResCategory.CarAudio), typeof(ResCategory))]
        CarAudio = 0,
        [LocalizedDescription(nameof(ResCategory.CarSpeakers), typeof(ResCategory))]
        CarSpeakers = 1,
        [LocalizedDescription(nameof(ResCategory.CarSubwoofers), typeof(ResCategory))]
        CarSubwoofers = 2,
        [LocalizedDescription(nameof(ResCategory.GPSSystems), typeof(ResCategory))]
        GPSSystems = 3
    }

    public enum CellPhoneAccessoriesCategory
    {
        [LocalizedDescription(nameof(ResCategory.CellPhoneCases), typeof(ResCategory))]
        CellPhoneCases = 0,
        [LocalizedDescription(nameof(ResCategory.CellPhoneMemoryCards), typeof(ResCategory))]
        CellPhoneMemoryCards = 1,
        [LocalizedDescription(nameof(ResCategory.SmartWatches), typeof(ResCategory))]
        SmartWatches = 2
    }

    public enum CellPhonesCategory
    {
        [LocalizedDescription(nameof(ResCategory.CellPhoneAccessories), typeof(ResCategory))]
        CellPhoneAccessories = 0,
        [LocalizedDescription(nameof(ResCategory.GooglePixel), typeof(ResCategory))]
        GooglePixel = 1,
        [LocalizedDescription(nameof(ResCategory.LGPhones), typeof(ResCategory))]
        LGPhones = 2,
        [LocalizedDescription(nameof(ResCategory.SamsungPhones), typeof(ResCategory))]
        SamsungPhones = 3,
        [LocalizedDescription(nameof(ResCategory.iPhones), typeof(ResCategory))]
        iPhones = 4
    }

    public enum ComputersCategory
    {
        [LocalizedDescription(nameof(ResCategory.ComputerCables), typeof(ResCategory))]
        ComputerCables = 0,
        [LocalizedDescription(nameof(ResCategory.ComputerCases), typeof(ResCategory))]
        ComputerCases = 1,
        [LocalizedDescription(nameof(ResCategory.ComputerHardDrives), typeof(ResCategory))]
        ComputerHardDrives = 2,
        [LocalizedDescription(nameof(ResCategory.ComputerHeadsets), typeof(ResCategory))]
        ComputerHeadsets = 3,
        [LocalizedDescription(nameof(ResCategory.ComputerKeyboards), typeof(ResCategory))]
        ComputerKeyboards = 4,
        [LocalizedDescription(nameof(ResCategory.ComputerMemoryAndRAM), typeof(ResCategory))]
        ComputerMemoryAndRAM = 5,
        [LocalizedDescription(nameof(ResCategory.ComputerMicrophones), typeof(ResCategory))]
        ComputerMicrophones = 6,
        [LocalizedDescription(nameof(ResCategory.ComputerSpeakers), typeof(ResCategory))]
        ComputerSpeakers = 7,
        [LocalizedDescription(nameof(ResCategory.DesktopComputers), typeof(ResCategory))]
        DesktopComputers = 8,
        [LocalizedDescription(nameof(ResCategory.HubsAndSwitches), typeof(ResCategory))]
        HubsAndSwitches = 9,
        [LocalizedDescription(nameof(ResCategory.Laptops), typeof(ResCategory))]
        Laptops = 10,
        [LocalizedDescription(nameof(ResCategory.ComputerMonitors), typeof(ResCategory))]
        ComputerMonitors = 11,
        [LocalizedDescription(nameof(ResCategory.RoutersAndModems), typeof(ResCategory))]
        RoutersAndModems = 12,
        [LocalizedDescription(nameof(ResCategory.TabletsAndeBooks), typeof(ResCategory))]
        TabletsAndeBooks = 13,
        [LocalizedDescription(nameof(ResCategory.VideoCards), typeof(ResCategory))]
        VideoCards = 14
    }

    public enum HomeAudioAndVideoSystemsCategory
    {
        [LocalizedDescription(nameof(ResCategory.AntennasAndDishes), typeof(ResCategory))]
        AntennasAndDishes = 0,
        [LocalizedDescription(nameof(ResCategory.DVDPlayers), typeof(ResCategory))]
        DVDPlayers = 1,
        [LocalizedDescription(nameof(ResCategory.HomeSpeakers), typeof(ResCategory))]
        HomeSpeakers = 2,
        [LocalizedDescription(nameof(ResCategory.HomeTheater), typeof(ResCategory))]
        HomeTheater = 3,
        [LocalizedDescription(nameof(ResCategory.MediaStreamers), typeof(ResCategory))]
        MediaStreamers = 4,
        [LocalizedDescription(nameof(ResCategory.StereoReceivers), typeof(ResCategory))]
        StereoReceivers = 5,
        [LocalizedDescription(nameof(ResCategory.TVs), typeof(ResCategory))]
        TVs = 6,
        [LocalizedDescription(nameof(ResCategory.TurntablesAndRecordPlayers), typeof(ResCategory))]
        TurntablesAndRecordPlayers = 7
    }

    public enum HomeAutomationSystemsCategory
    {
        [LocalizedDescription(nameof(ResCategory.SmartHomeDevices), typeof(ResCategory))]
        SmartHomeDevices = 0
    }

    public enum PortableAudioAndVideoCategory
    {
        [LocalizedDescription(nameof(ResCategory.Boomboxes), typeof(ResCategory))]
        Boomboxes = 0,
        [LocalizedDescription(nameof(ResCategory.Headphones), typeof(ResCategory))]
        Headphones = 1,
        [LocalizedDescription(nameof(ResCategory.Jukeboxes), typeof(ResCategory))]
        Jukeboxes = 2,
        [LocalizedDescription(nameof(ResCategory.KaraokeMachines), typeof(ResCategory))]
        KaraokeMachines = 3
    }

    public enum VideoGamesAndConsolesCategory
    {
        [LocalizedDescription(nameof(ResCategory.ArcadeMachines), typeof(ResCategory))]
        ArcadeMachines = 0,
        [LocalizedDescription(nameof(ResCategory.GamingHeadsets), typeof(ResCategory))]
        GamingHeadsets = 1,
        [LocalizedDescription(nameof(ResCategory.VideoGameConsoles), typeof(ResCategory))]
        VideoGameConsoles = 2,
        [LocalizedDescription(nameof(ResCategory.VideoGameControllers), typeof(ResCategory))]
        VideoGameControllers = 3,
        [LocalizedDescription(nameof(ResCategory.VideoGames), typeof(ResCategory))]
        VideoGames = 4,
        [LocalizedDescription(nameof(ResCategory.VirtualRealityHeadsets), typeof(ResCategory))]
        VirtualRealityHeadsets = 5
    }

    public enum EntertainmentCategory
    {
        [LocalizedDescription(nameof(ResCategory.BooksMoviesAndMusic), typeof(ResCategory))]
        BooksMoviesAndMusic = 0
    }

    public enum FamilyCategory
    {
        [LocalizedDescription(nameof(ResCategory.BabyAndKidsItems), typeof(ResCategory))]
        BabyAndKidsItems = 0,
        [LocalizedDescription(nameof(ResCategory.HealthAndBeauty), typeof(ResCategory))]
        HealthAndBeauty = 1,
        [LocalizedDescription(nameof(ResCategory.PetSupplies), typeof(ResCategory))]
        PetSupplies = 2,
        [LocalizedDescription(nameof(ResCategory.ToysAndGames), typeof(ResCategory))]
        ToysAndGames = 3
    }

    public enum BabyAndKidsItemsCategory
    {
        [LocalizedDescription(nameof(ResCategory.BabyAndToddlerFeedingSupplies), typeof(ResCategory))]
        BabyAndToddlerFeedingSupplies = 0,
        [LocalizedDescription(nameof(ResCategory.BabyBathingSupplies), typeof(ResCategory))]
        BabyBathingSupplies = 1,
        [LocalizedDescription(nameof(ResCategory.BabyCarriers), typeof(ResCategory))]
        BabyCarriers = 2,
        [LocalizedDescription(nameof(ResCategory.BabyDiaperingItems), typeof(ResCategory))]
        BabyDiaperingItems = 3,
        [LocalizedDescription(nameof(ResCategory.BabyGear), typeof(ResCategory))]
        BabyGear = 4,
        [LocalizedDescription(nameof(ResCategory.BabySafetyAndHealth), typeof(ResCategory))]
        BabySafetyAndHealth = 5,
        [LocalizedDescription(nameof(ResCategory.BabyStrollers), typeof(ResCategory))]
        BabyStrollers = 6,
        [LocalizedDescription(nameof(ResCategory.BabyToys), typeof(ResCategory))]
        BabyToys = 7,
        [LocalizedDescription(nameof(ResCategory.CarSeatsAndAccessories), typeof(ResCategory))]
        CarSeatsAndAccessories = 8,
        [LocalizedDescription(nameof(ResCategory.NurseryBedding), typeof(ResCategory))]
        NurseryBedding = 9,
        [LocalizedDescription(nameof(ResCategory.NurseryDecor), typeof(ResCategory))]
        NurseryDecor = 10,
        [LocalizedDescription(nameof(ResCategory.PottyTrainingItems), typeof(ResCategory))]
        PottyTrainingItems = 11
    }

    public enum HealthAndBeautyCategory
    {
        [LocalizedDescription(nameof(ResCategory.BeautyProducts), typeof(ResCategory))]
        BeautyProducts = 0,
        [LocalizedDescription(nameof(ResCategory.HealthCareProducts), typeof(ResCategory))]
        HealthCareProducts = 1,
        [LocalizedDescription(nameof(ResCategory.PersonalCareProducts), typeof(ResCategory))]
        PersonalCareProducts = 2
    }

    public enum PetSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.BirdSupplies), typeof(ResCategory))]
        BirdSupplies = 0,
        [LocalizedDescription(nameof(ResCategory.CatSupplies), typeof(ResCategory))]
        CatSupplies = 1,
        [LocalizedDescription(nameof(ResCategory.ChickenSupplies), typeof(ResCategory))]
        ChickenSupplies = 2,
        [LocalizedDescription(nameof(ResCategory.DogSupplies), typeof(ResCategory))]
        DogSupplies = 3,
        [LocalizedDescription(nameof(ResCategory.FishSupplies), typeof(ResCategory))]
        FishSupplies = 4,
        [LocalizedDescription(nameof(ResCategory.PetCrates), typeof(ResCategory))]
        PetCrates = 5,
        [LocalizedDescription(nameof(ResCategory.PetKennels), typeof(ResCategory))]
        PetKennels = 6,
        [LocalizedDescription(nameof(ResCategory.ReptileSupplies), typeof(ResCategory))]
        ReptileSupplies = 7
    }

    public enum BirdSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.BirdCages), typeof(ResCategory))]
        BirdCages = 0,
        [LocalizedDescription(nameof(ResCategory.BirdPerches), typeof(ResCategory))]
        BirdPerches = 1,
    }

    public enum CatSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.CatScratchers), typeof(ResCategory))]
        CatScratchers = 0,
        [LocalizedDescription(nameof(ResCategory.CatToys), typeof(ResCategory))]
        CatToys = 1,
        [LocalizedDescription(nameof(ResCategory.CatTrees), typeof(ResCategory))]
        CatTrees = 2,
        [LocalizedDescription(nameof(ResCategory.LitterBoxes), typeof(ResCategory))]
        LitterBoxes = 3
    }

    public enum ChickenSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.ChickenCoops), typeof(ResCategory))]
        ChickenCoops = 0,
        [LocalizedDescription(nameof(ResCategory.ChickenFeeders), typeof(ResCategory))]
        ChickenFeeders = 1
    }

    public enum DogSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.DogHouses), typeof(ResCategory))]
        DogHouses = 0,
        [LocalizedDescription(nameof(ResCategory.DogToys), typeof(ResCategory))]
        DogToys = 1,
    }

    public enum FishSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AquariumDecorations), typeof(ResCategory))]
        AquariumDecorations = 0,
        [LocalizedDescription(nameof(ResCategory.AquariumFilters), typeof(ResCategory))]
        AquariumFilters = 1,
        [LocalizedDescription(nameof(ResCategory.FishAquariums), typeof(ResCategory))]
        FishAquariums = 2
    }

    public enum ReptileSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.ReptileCages), typeof(ResCategory))]
        ReptileCages = 0
    }

    public enum SportingGoodsCategory
    {
        [LocalizedDescription(nameof(ResCategory.Bicycles), typeof(ResCategory))]
        Bicycles = 0,
        [LocalizedDescription(nameof(ResCategory.ExerciseAndFitnessEquipment), typeof(ResCategory))]
        ExerciseAndFitnessEquipment = 1,
        [LocalizedDescription(nameof(ResCategory.IndoorGames), typeof(ResCategory))]
        IndoorGames = 2,
        [LocalizedDescription(nameof(ResCategory.Kayaks), typeof(ResCategory))]
        Kayaks = 3,
        [LocalizedDescription(nameof(ResCategory.OutdoorGames), typeof(ResCategory))]
        OutdoorGames = 4,
        [LocalizedDescription(nameof(ResCategory.OutdoorRecreationEquipment), typeof(ResCategory))]
        OutdoorRecreationEquipment = 5,
        [LocalizedDescription(nameof(ResCategory.SportsEquipment), typeof(ResCategory))]
        SportsEquipment = 6
    }

    public enum ExerciseAndFitnessEquipmentCategory
    {
        [LocalizedDescription(nameof(ResCategory.AbMachines), typeof(ResCategory))]
        AbMachines = 0,
    }

    public enum IndoorGamesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AirHockey), typeof(ResCategory))]
        AirHockey = 0,
        [LocalizedDescription(nameof(ResCategory.BowlingAccessories), typeof(ResCategory))]
        BowlingAccessories = 1,
        [LocalizedDescription(nameof(ResCategory.Dartboards), typeof(ResCategory))]
        Dartboards = 2,
        [LocalizedDescription(nameof(ResCategory.FoosballTables), typeof(ResCategory))]
        FoosballTables = 3,
        [LocalizedDescription(nameof(ResCategory.PingPongEquipment), typeof(ResCategory))]
        PingPongEquipment = 4,
        [LocalizedDescription(nameof(ResCategory.PoolCues), typeof(ResCategory))]
        PoolCues = 5,
        [LocalizedDescription(nameof(ResCategory.PoolTables), typeof(ResCategory))]
        PoolTables = 6
    }

    public enum OutdoorGamesCategory
    {
        [LocalizedDescription(nameof(ResCategory.DiscGolfEquipment), typeof(ResCategory))]
        DiscGolfEquipment = 0,
        [LocalizedDescription(nameof(ResCategory.LawnGames), typeof(ResCategory))]
        LawnGames = 1,
        [LocalizedDescription(nameof(ResCategory.OutdoorToys), typeof(ResCategory))]
        OutdoorToys = 2
    }

    public enum OutdoorRecreationEquipmentCategory
    {
        [LocalizedDescription(nameof(ResCategory.AirsoftEquipment), typeof(ResCategory))]
        AirsoftEquipment = 0,
        [LocalizedDescription(nameof(ResCategory.CampingAndHikingEquipment), typeof(ResCategory))]
        CampingAndHikingEquipment = 1,
        [LocalizedDescription(nameof(ResCategory.EquestrianEquipment), typeof(ResCategory))]
        EquestrianEquipment = 2,
        [LocalizedDescription(nameof(ResCategory.FishingGear), typeof(ResCategory))]
        FishingGear = 3,
        [LocalizedDescription(nameof(ResCategory.RollerSkatingGear), typeof(ResCategory))]
        RollerSkatingGear = 4,
        [LocalizedDescription(nameof(ResCategory.SkateboardingGear), typeof(ResCategory))]
        SkateboardingGear = 5,
        [LocalizedDescription(nameof(ResCategory.WaterSportsAndBoatingEquipment), typeof(ResCategory))]
        WaterSportsAndBoatingEquipment = 6,
        [LocalizedDescription(nameof(ResCategory.WinterSportsEquipment), typeof(ResCategory))]
        WinterSportsEquipment = 7
    }

    public enum SportsEquipmentCategory
    {
        [LocalizedDescription(nameof(ResCategory.BaseballGear), typeof(ResCategory))]
        BaseballGear = 0,
        [LocalizedDescription(nameof(ResCategory.BasketballGear), typeof(ResCategory))]
        BasketballGear = 1,
        [LocalizedDescription(nameof(ResCategory.FootballGear), typeof(ResCategory))]
        FootballGear = 2,
        [LocalizedDescription(nameof(ResCategory.GolfEquipment), typeof(ResCategory))]
        GolfEquipment = 3,
        [LocalizedDescription(nameof(ResCategory.GymnasticsEquipment), typeof(ResCategory))]
        GymnasticsEquipment = 4,
        [LocalizedDescription(nameof(ResCategory.HockeyEquipment), typeof(ResCategory))]
        HockeyEquipment = 5,
        [LocalizedDescription(nameof(ResCategory.LacrosseGear), typeof(ResCategory))]
        LacrosseGear = 6,
        [LocalizedDescription(nameof(ResCategory.TennisEquipment), typeof(ResCategory))]
        TennisEquipment = 7
    }

    public enum ToysAndGamesCategory
    {
        [LocalizedDescription(nameof(ResCategory.ActionFigures), typeof(ResCategory))]
        ActionFigures = 0,
        [LocalizedDescription(nameof(ResCategory.BuildingToys), typeof(ResCategory))]
        BuildingToys = 1,
        [LocalizedDescription(nameof(ResCategory.Dollhouses), typeof(ResCategory))]
        Dollhouses = 2,
        [LocalizedDescription(nameof(ResCategory.Dolls), typeof(ResCategory))]
        Dolls = 3,
        [LocalizedDescription(nameof(ResCategory.EducationalToys), typeof(ResCategory))]
        EducationalToys = 4,
        [LocalizedDescription(nameof(ResCategory.Games), typeof(ResCategory))]
        Games = 5,
        [LocalizedDescription(nameof(ResCategory.ModelKits), typeof(ResCategory))]
        ModelKits = 6,
        [LocalizedDescription(nameof(ResCategory.OutdoorToys), typeof(ResCategory))]
        OutdoorToys = 7,
        [LocalizedDescription(nameof(ResCategory.IndoorAndOutdoorKidsPlayhouses), typeof(ResCategory))]
        IndoorAndOutdoorKidsPlayhouses = 8,
        [LocalizedDescription(nameof(ResCategory.PlayKitchens), typeof(ResCategory))]
        PlayKitchens = 9,
        [LocalizedDescription(nameof(ResCategory.Puzzles), typeof(ResCategory))]
        Puzzles = 10,
        [LocalizedDescription(nameof(ResCategory.RemoteControlToys), typeof(ResCategory))]
        RemoteControlToys = 11,
        [LocalizedDescription(nameof(ResCategory.StuffedAnimals), typeof(ResCategory))]
        StuffedAnimals = 12,
        [LocalizedDescription(nameof(ResCategory.ToyVehicles), typeof(ResCategory))]
        ToyVehicles = 13
    }

    public enum EducationalToysCategory
    {
        [LocalizedDescription(nameof(ResCategory.MathToys), typeof(ResCategory))]
        MathToys = 0
    }

    public enum GamesCategory
    {
        [LocalizedDescription(nameof(ResCategory.AirHockey), typeof(ResCategory))]
        AirHockey = 0,
        [LocalizedDescription(nameof(ResCategory.BoardGames), typeof(ResCategory))]
        BoardGames = 1,
        [LocalizedDescription(nameof(ResCategory.BowlingAccessories), typeof(ResCategory))]
        BowlingAccessories = 2,
        [LocalizedDescription(nameof(ResCategory.CardGames), typeof(ResCategory))]
        CardGames = 3,
        [LocalizedDescription(nameof(ResCategory.ChessSets), typeof(ResCategory))]
        ChessSets = 4,
        [LocalizedDescription(nameof(ResCategory.Dartboards), typeof(ResCategory))]
        Dartboards = 5,
        [LocalizedDescription(nameof(ResCategory.DiceGames), typeof(ResCategory))]
        DiceGames = 6,
        [LocalizedDescription(nameof(ResCategory.FoosballTables), typeof(ResCategory))]
        FoosballTables = 7,
        [LocalizedDescription(nameof(ResCategory.PingPongEquipment), typeof(ResCategory))]
        PingPongEquipment = 8,
        [LocalizedDescription(nameof(ResCategory.PokerChips), typeof(ResCategory))]
        PokerChips = 9,
        [LocalizedDescription(nameof(ResCategory.PoolTables), typeof(ResCategory))]
        PoolTables = 10,
        [LocalizedDescription(nameof(ResCategory.TradingCards), typeof(ResCategory))]
        TradingCards = 11,
        [LocalizedDescription(nameof(ResCategory.WarBoardGames), typeof(ResCategory))]
        WarBoardGames = 12
    }

    public enum OutdoorToysCategory
    {
        [LocalizedDescription(nameof(ResCategory.BackyardPlaygrounds), typeof(ResCategory))]
        BackyardPlaygrounds = 0,
        [LocalizedDescription(nameof(ResCategory.BallPits), typeof(ResCategory))]
        BallPits = 1,
        [LocalizedDescription(nameof(ResCategory.DartGuns), typeof(ResCategory))]
        DartGuns = 2,
        [LocalizedDescription(nameof(ResCategory.HulaHoops), typeof(ResCategory))]
        HulaHoops = 3,
        [LocalizedDescription(nameof(ResCategory.InflatableBouncers), typeof(ResCategory))]
        InflatableBouncers = 4,
        [LocalizedDescription(nameof(ResCategory.KiddiePools), typeof(ResCategory))]
        KiddiePools = 5,
        [LocalizedDescription(nameof(ResCategory.Kites), typeof(ResCategory))]
        Kites = 6,
        [LocalizedDescription(nameof(ResCategory.OutdoorGames), typeof(ResCategory))]
        OutdoorGames = 7,
        [LocalizedDescription(nameof(ResCategory.PogoSticks), typeof(ResCategory))]
        PogoSticks = 8,
        [LocalizedDescription(nameof(ResCategory.WaterTables), typeof(ResCategory))]
        WaterTables = 9,
        [LocalizedDescription(nameof(ResCategory.Trampolines), typeof(ResCategory))]
        Trampolines = 10
    }

    public enum GardenAndOutdoorCategory
    {
        [LocalizedDescription(nameof(ResCategory.BirdAndWildlifeAccessories), typeof(ResCategory))] BirdAndWildlifeAccessories = 0,
        [LocalizedDescription(nameof(ResCategory.FencingSupplies), typeof(ResCategory))] FencingSupplies = 1,
        [LocalizedDescription(nameof(ResCategory.GardenDecor), typeof(ResCategory))] GardenDecor = 2,
        [LocalizedDescription(nameof(ResCategory.GardenStructures), typeof(ResCategory))] GardenStructures = 3,
        [LocalizedDescription(nameof(ResCategory.GardeningSupplies), typeof(ResCategory))] GardeningSupplies = 4,
        [LocalizedDescription(nameof(ResCategory.LawnMowers), typeof(ResCategory))] LawnMowers = 5,
        [LocalizedDescription(nameof(ResCategory.OutdoorCooking), typeof(ResCategory))] OutdoorCooking = 6,
        [LocalizedDescription(nameof(ResCategory.OutdoorLighting), typeof(ResCategory))] OutdoorLighting = 7,
        [LocalizedDescription(nameof(ResCategory.OutdoorPowerEquipment), typeof(ResCategory))] OutdoorPowerEquipment = 8,
        [LocalizedDescription(nameof(ResCategory.PatioFurniture), typeof(ResCategory))] PatioFurniture = 9,
        [LocalizedDescription(nameof(ResCategory.PoolsAndSpas), typeof(ResCategory))] PoolsAndSpas = 10,
        [LocalizedDescription(nameof(ResCategory.PowerTools), typeof(ResCategory))] PowerTools = 11,
    }

    public enum GardenStructuresCategory
    {
        [LocalizedDescription(nameof(ResCategory.Arbors), typeof(ResCategory))] Arbors = 0,
        [LocalizedDescription(nameof(ResCategory.Gazebos), typeof(ResCategory))] Gazebos = 1,
        [LocalizedDescription(nameof(ResCategory.StorageSheds), typeof(ResCategory))] StorageSheds = 2,
        [LocalizedDescription(nameof(ResCategory.PatioUmbrellas), typeof(ResCategory))] PatioUmbrellas = 3
    }

    public enum GardeningSuppliesCategory
    {
        [LocalizedDescription(nameof(ResCategory.Composters), typeof(ResCategory))] Composters = 0,
        [LocalizedDescription(nameof(ResCategory.GardenTools), typeof(ResCategory))] GardenTools = 1,
        [LocalizedDescription(nameof(ResCategory.HydroponicSupplies), typeof(ResCategory))] HydroponicSupplies = 2,
        [LocalizedDescription(nameof(ResCategory.LandscapingMaterials), typeof(ResCategory))] LandscapingMaterials = 3,
        [LocalizedDescription(nameof(ResCategory.PlantSupplies), typeof(ResCategory))] PlantSupplies = 4,
        [LocalizedDescription(nameof(ResCategory.PlantsSeedsAndBulbs), typeof(ResCategory))] PlantsSeedsAndBulbs = 5,
        [LocalizedDescription(nameof(ResCategory.WateringEquipment), typeof(ResCategory))] WateringEquipment = 6,
    }

    public enum RemoteControlToysCategory
    {
        [LocalizedDescription(nameof(ResCategory.RemoteToyCarsAndTrucks), typeof(ResCategory))]
        RemoteToyCarsAndTrucks = 0
    }

    public enum ToyVehiclesCategory
    {
        [LocalizedDescription(nameof(ResCategory.ToyAirplanes), typeof(ResCategory))]
        ToyAirplanes = 0,
        [LocalizedDescription(nameof(ResCategory.ToyBoats), typeof(ResCategory))]
        ToyBoats = 1,
        [LocalizedDescription(nameof(ResCategory.ToyCars), typeof(ResCategory))]
        ToyCars = 2,
        [LocalizedDescription(nameof(ResCategory.ToyConstructionVehicles), typeof(ResCategory))]
        ToyConstructionVehicles = 3
    }
}
