﻿namespace com.hotelbeds.distribution.hotel_api_sdk.types
{
    public class HotelApiVersion
    {
        public enum versions { V0_2, V1, V1_1, V1_2};

        public versions version { get; }

        public HotelApiVersion(versions version)
        {
            this.version = version;
        }
    }
}
