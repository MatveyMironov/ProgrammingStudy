using System.Drawing;

namespace FacadePatternStudyProject
{
    internal class SmartHome
    {
        private Dictionary<HomeModes, HomeConfiguration> _homeModesConfigurations;

        public SmartHome()
        {
            _homeModesConfigurations = new();

            FillHomeModesConfigurations();

            Light = new();
            TV = new();
            AirConditioner = new();
            MusicStation = new();
        }

        private void FillHomeModesConfigurations()
        {
            HomeConfiguration nightConfiguration = new(false, 0, Color.White, false, "", true, 20, false, "");
            _homeModesConfigurations.Add(HomeModes.night, nightConfiguration);

            HomeConfiguration morningConfiguration = new(true, 10000, Color.White, true, "Morning News", true, 25, true, "Good Morning");
            _homeModesConfigurations.Add(HomeModes.morning, morningConfiguration);

            HomeConfiguration partyConfiguration = new(true, 4000, Color.Yellow, false, "", true, 20, true, "Party Playlist");
            _homeModesConfigurations.Add(HomeModes.party, partyConfiguration);
        }

        public Light Light { get; private set; }
        public TV TV { get; private set; }
        public AirConditioner AirConditioner { get; private set; }
        public MusicStation MusicStation { get; private set; }

        public enum HomeModes
        {
            night,
            morning,
            party,
        }

        public void SetUpHome(HomeModes homeModes)
        {
            if (_homeModesConfigurations.ContainsKey(homeModes))
            {
                HomeConfiguration newConfiguration = _homeModesConfigurations[homeModes];

                if (Light.IsTurnedOn != newConfiguration.IsLightTurnedOn)
                {
                    Light.SwitchLight();
                }
                Light.ChangeBrightness(newConfiguration.Brightness);
                Light.ChangeColor(newConfiguration.Color);

                if (TV.IsTurnedOn != newConfiguration.IsTVTurnedOn)
                {
                    TV.SwitchTV();
                }
                TV.TurnOnProgram(newConfiguration.ActiveProgram);

                if (AirConditioner.IsTurnedOn != newConfiguration.IsAirConditionerTurnedOn)
                {
                    AirConditioner.Switch();
                }
                AirConditioner.SetTemperature(newConfiguration.Temperature);

                if (MusicStation.IsTurnedOn != newConfiguration.IsMusicStationTurnedOn)
                {
                    MusicStation.Switch();
                }
                MusicStation.SetMusic(newConfiguration.Music);

                Console.WriteLine(Light.ToString());
                Console.WriteLine(TV.ToString());
                Console.WriteLine(AirConditioner.ToString());
                Console.WriteLine(MusicStation.ToString());
            }
        }

        private struct HomeConfiguration
        {
            public HomeConfiguration(bool isLightTurnedOn,
                                     int brightness,
                                     Color color,
                                     bool isTVTurnedOn,
                                     string activeProgram,
                                     bool isAirConditionerTurnedOn,
                                     int temperature,
                                     bool isMusicStationTurnedOn,
                                     string music)
            {
                IsLightTurnedOn = isLightTurnedOn;
                Brightness = brightness;
                Color = color;
                IsTVTurnedOn = isTVTurnedOn;
                ActiveProgram = activeProgram;
                IsAirConditionerTurnedOn = isAirConditionerTurnedOn;
                Temperature = temperature;
                IsMusicStationTurnedOn = isMusicStationTurnedOn;
                Music = music;
            }

            public bool IsLightTurnedOn { get; private set; }
            public int Brightness { get; private set; }
            public Color Color { get; private set; }

            public bool IsTVTurnedOn { get; private set; }
            public string ActiveProgram { get; private set; }

            public bool IsAirConditionerTurnedOn { get; private set; }
            public int Temperature { get; private set; }

            public bool IsMusicStationTurnedOn { get; private set; }
            public string Music { get; private set; }
        }
    }
}
