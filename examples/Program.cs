// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Services;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Common;

using static Google.Ads.GoogleAds.V6.Enums.AgeRangeTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.GenderTypeEnum.Types;

using static Google.Ads.GoogleAds.V6.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.KeywordPlanNetworkEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.ProximityRadiusUnitsEnum.Types;

using Microsoft.Data.Analysis;
using XPlot.Plotly;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// The Main class for this application.
    /// </summary>
    internal class Program
    {
        public static void getCampaignInfo(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/reporting/criteria-metrics

            /* 
             * 
             * cost_micros: The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period.
             * average_cost: The average amount you pay per interaction. This amount is the total cost of your ads divided by the total number of interactions.
             * average_cpc: The total cost of all clicks divided by the total number of clicks received.
             * average_cpm: Average cost-per-thousand impressions (CPM).
             * bounce_rate: Percentage of clicks where the user only visited a single page on your site. Imported from Google Analytics.
             */

            /*
                 ad_group_ad.ad.id,
                 ad_group_ad.status,
            */

            string query2 =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 ad_group.id,
                 ad_group.name,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM ad_group
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query2,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                //$"Ad ID: {dataRow.AdGroupAd.Ad.Id}\nAd status: {dataRow.AdGroupAd.Status}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void getAdGroupAdInfo(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/reporting/criteria-metrics

            /* 
             * 
             * cost_micros: The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period.
             * average_cost: The average amount you pay per interaction. This amount is the total cost of your ads divided by the total number of interactions.
             * average_cpc: The total cost of all clicks divided by the total number of clicks received.
             * average_cpm: Average cost-per-thousand impressions (CPM).
             * bounce_rate: Percentage of clicks where the user only visited a single page on your site. Imported from Google Analytics.
             */

            string query =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 ad_group.id,
                 ad_group.name,
                 ad_group_ad.ad.id,
                 ad_group_ad.status,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM ad_group_ad
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Ad ID: {dataRow.AdGroupAd.Ad.Id}\nAd status: {dataRow.AdGroupAd.Status}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void getCampaignKeywordsInfo(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/reporting/criteria-metrics

            /*
                            ad_group.id,
                            ad_group.name,
                            ad_group_criterion.keyword.text,
                            metrics.ctr,
                            metrics.average_cpc
                            campaign.network_settings.target_content_network

            string query = @"SELECT
                            campaign.id,
                            campaign.name,
                            campaign.start_date,
                            campaign.status,
                            metrics.bounce_rate,
                            metrics.clicks,
                            metrics.impressions,
                            metrics.ctr
                        FROM campaign
                        WHERE segments.date = '2021-03-10'";
            //ORDER BY campaign.id";
            */
            /* clicks,conversions,frequency,cpc,cpm,website_purchase_roas,purchase_roas,reach,impressions,spend,objective
             * 
             * cost_micros: The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period.
             * average_cost: The average amount you pay per interaction. This amount is the total cost of your ads divided by the total number of interactions.
             * average_cpc: The total cost of all clicks divided by the total number of clicks received.
             * average_cpm: Average cost-per-thousand impressions (CPM).
             * bounce_rate: Percentage of clicks where the user only visited a single page on your site. Imported from Google Analytics.
             */
            /*
            string query1 =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 ad_group.id,
                 ad_group.name,
                 ad_group_criterion.criterion_id,
                 ad_group_criterion.keyword.text,
                 ad_group_criterion.keyword.match_type,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate,
                 metrics.interactions
             FROM keyword_view
             WHERE segments.date DURING LAST_7_DAYS
                 AND ad_group.status = 'ENABLED'
                 AND ad_group_criterion.status IN ('ENABLED','PAUSED')
             ";
            */

            /* Keyword_view: https://developers.google.com/google-ads/api/fields/v6/keyword_view
             */

            string query2 =
                $@"SELECT
                    ad_group.id,
                    ad_group.status,
                    ad_group_criterion.criterion_id,
                    ad_group_criterion.keyword.text,
                    ad_group_criterion.keyword.match_type,

                 campaign.id,
                 campaign.name,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM keyword_view
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.

                /*
                googleAdsService.SearchStream(customerId.ToString(), query1,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow criterionRow in resp.Results)
                        {
                            Console.WriteLine(
                                "Keyword with text " +
                                $"'{criterionRow.AdGroupCriterion.Keyword.Text}', match type " +
                                $"'{criterionRow.AdGroupCriterion.Keyword.MatchType}' and ID " +
                                $"{criterionRow.AdGroupCriterion.CriterionId} in ad group " +
                                $"'{criterionRow.AdGroup.Name}' with ID " +
                                $"{criterionRow.AdGroup.Id} in campaign " +
                                $"'{criterionRow.Campaign.Name}' with ID " +
                                $"{criterionRow.Campaign.Id} had " +
                                $"{criterionRow.Metrics.Impressions.ToString()} impressions, " +
                                $"{criterionRow.Metrics.Clicks} clicks, and " +
                                $"{criterionRow.Metrics.CostMicros} cost (in micros) during the " +
                                "last 7 days. \n\n");
                        }
                    }
                );
                */

                googleAdsService.SearchStream(customerId.ToString(), query2,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Resource Name: {dataRow.KeywordView.ResourceName}\n" +
                                $"Keyword: '{dataRow.AdGroupCriterion.Keyword.Text}'\n" +
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" /*+
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"*/
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
        public static void getGeoTarget(long customerId, long campaignId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/targeting/location-targeting#c

            string query =
                $@"SELECT
                  campaign_criterion.campaign,
                  campaign_criterion.criterion_id,
                  campaign_criterion.location.geo_target_constant,
                  campaign_criterion.proximity.geo_point.longitude_in_micro_degrees,
                  campaign_criterion.proximity.geo_point.latitude_in_micro_degrees,
                  campaign_criterion.proximity.radius,
                  campaign_criterion.negative
            FROM campaign_criterion
            WHERE campaign_criterion.campaign = 'customers/{customerId}/campaigns/{campaignId}'
                AND campaign_criterion.type IN (LOCATION, PROXIMITY)
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        Console.WriteLine("Geo Target Location(s):\n");
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign Name: {dataRow.CampaignCriterion.Campaign}\n" +
                                $"Campaign location geo target constant: {dataRow.CampaignCriterion.Location?.GeoTargetConstant}\n" +
                                $"Campaign Criterion ID: {dataRow.CampaignCriterion.CriterionId}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void getAudienceInfo(long customerId, long campaignId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/targeting/location-targeting#c

            string query =
                $@"SELECT
                  campaign_criterion.campaign,
                  campaign_criterion.criterion_id,
                  campaign_criterion.age_range.type,
                  campaign_criterion.gender.type,
                  campaign_criterion.negative
            FROM campaign_criterion
            WHERE campaign_criterion.campaign = 'customers/{customerId}/campaigns/{campaignId}'
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        Console.WriteLine("Demographics Info:\n");
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            Console.WriteLine(
                                $"Campaign Name: {dataRow.CampaignCriterion.Campaign}\n" +
                                $"Campaign Criterion ID: {dataRow.CampaignCriterion.CriterionId}\n" +
                                $"Age Range Type: {dataRow.CampaignCriterion.AgeRange?.Type}\n" +
                                $"Gender Type: {dataRow.CampaignCriterion.Gender?.Type}\n" +
                                $"Negative Status: {dataRow.CampaignCriterion.Negative}\n\n"
                                );
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static CampaignCriterion buildLocationCriterion(long customerId, long campaignId, long locationId)
        {
            // Set the Campaign Resource Name
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            GeoTargetConstantName location = new GeoTargetConstantName(locationId.ToString());
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Location = new LocationInfo()
                {
                    GeoTargetConstant = location.ToString()
                }
            };
        }

        //Please refer to "AddDemographicTargetingCriteria.cs"
        public static CampaignCriterion buildAgeRangeCriterion(long customerId, long campaignId)
        {
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Creates a negative campaign criterion for age range.
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                // Makes this ad group criterion negative.
                Negative = true,
                // Targets the age range of 18 to 24.
                AgeRange = new AgeRangeInfo()
                {
                    Type = AgeRangeType.AgeRange1824
                }
            };
        }

        public static CampaignCriterion buildGenderCriterion(long customerId, long campaignId, GenderInfo genderValue)
        {
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            Console.WriteLine(genderValue.Type.ToString());

            // Creates a NEGATIVE campaign criterion for GENDER.
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                // Makes this criterion negative.
                Negative = true,
                
                // COULDN'T GET THIS WORKING... NEED HELP
                Gender = //genderValue
                // /*
                new GenderInfo()
                {
                    Type = GenderType.Undetermined
                }
                // */
            };
        }

        public static AdGroupCriterion buildCustomInterestCriterion(long customerId, long adGroupId, string interest)
        {
            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            Console.WriteLine(interest);

            // Creates a NEGATIVE campaign criterion for GENDER.
            return new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                // Makes this criterion negative.
                Negative = false,

                // COULDN'T GET THIS WORKING... NEED HELP
                CustomIntent = new CustomIntentInfo()
                    {
                        CustomIntent = adGroupResourceName,
                        
                }
            };
        }


        public static CampaignCriterion buildKeywordCampaignCriterion(long customerId, long campaignId, bool is_search, string searchTerm)
        {
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);
            
            // Creates a ...
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                // Makes this criterion POSITIVE / NEGATIVE based on input
                Negative = is_search,
                // Keyword based on input text
                Keyword = new KeywordInfo()
                {
                    MatchType = GoogleAds.V6.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Broad,
                    Text = searchTerm
                }
            };
        }

        public static AdGroupCriterion buildKeywordAdGroupCriterion(long customerId, long adGroupId, bool is_search, string searchTerm)
        {
            //string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            // Creates a ...
            return new AdGroupCriterion()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Status = AdGroupCriterionStatus.Enabled,
                // Makes this criterion POSITIVE / NEGATIVE based on input
                Negative = is_search,
                // Keyword based on input text
                Keyword = new KeywordInfo()
                {
                    
                    Text = searchTerm,
                    MatchType = KeywordMatchType.Exact
                    //MatchType = GoogleAds.V6.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Broad
                }
            };
        }

        /// <summary>
        /// Creates a proximity Criterion.
        /// </summary>
        public static CampaignCriterion buildProximityCriterion(long customerId, long campaignId)
        {
            // Set the Campaign Resource Name
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            ProximityInfo proximity = new ProximityInfo()
            {
                Address = new AddressInfo()
                {
                    StreetAddress = "1140 alskdfjasldfSheppard Ave W Suite 20",
                    CityName = "North York",
                    //PostalCode = "M3K 2A2",
                    CountryCode = "CA"
                },
                Radius = 10d,
                // Default is kilometers.
                RadiusUnits = ProximityRadiusUnits.Kilometers
            };

            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Proximity = proximity
            };
        }
        public static void addGeoTargetLocationCriterion(long customerId, long campaignId, long locationId)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V6.CampaignCriterionService);

            //1. locationId
            //CampaignCriterion geoCriterion = buildLocationCriterion(customerId, campaignId, locationId);

            //2. address
            CampaignCriterion geoCriterion = buildProximityCriterion(customerId, campaignId);
            //CampaignCriterion geoCriterion = new V6.AddCampaignTargetingCriteria().buildProximityCriterion(campaignResourceName);

            //Console.WriteLine(geoCriterion.Campaign.ToString());
            //Console.WriteLine(geoCriterion.Proximity.Radius.ToString());
            //Console.ReadLine();

            CampaignCriterionOperation geoCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = geoCriterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                //negativeCriterionOperation,
                //locationCriterionOperation,
                //proximityCriterionOperation
                geoCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' and " +
                        $"Address = '{criterionResult.CampaignCriterion?.Proximity.Address}' and " +
                        $"Radius = '{criterionResult.CampaignCriterion?.Proximity.Radius.ToString()} " +
                        $"{criterionResult.CampaignCriterion?.Proximity.RadiusUnits.ToString()}' and " +
                        $"campaign ID {campaignId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void addAgeRangeCriterion(long customerId, long campaignId)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V6.CampaignCriterionService);

            CampaignCriterion ageRangeCriterion = buildAgeRangeCriterion(customerId, campaignId);

            CampaignCriterionOperation ageRangeCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = ageRangeCriterion
                };


            CampaignCriterionOperation[] operations2 = new CampaignCriterionOperation[] {
                //negativeCriterionOperation,
                ageRangeCriterionOperation,
                //proximityCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations2);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' and AgeRange = " +
                        $"'{criterionResult.CampaignCriterion?.AgeRange.ToString()}' was added to campaign " +
                        $"ID {campaignId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void addGenderCriterion(long customerId, long campaignId)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V6.CampaignCriterionService);

            // Negative on Undetermined AND Unknwon
            GenderInfo genderT1 = new GenderInfo { Type = GenderType.Undetermined };
            GenderInfo genderT2 = new GenderInfo { Type = GenderType.Unknown };

            CampaignCriterion genderT1Criterion = buildGenderCriterion(customerId, campaignId, genderT1);
            CampaignCriterion genderT2Criterion = buildGenderCriterion(customerId, campaignId, genderT2);

            Console.WriteLine(genderT1Criterion.Campaign.ToString());
            Console.WriteLine(genderT1Criterion.Type.ToString());
            Console.WriteLine(genderT2Criterion.Campaign.ToString());
            Console.WriteLine(genderT2Criterion.Type.ToString());

            CampaignCriterionOperation genderT1CriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = genderT1Criterion
                };

            CampaignCriterionOperation genderT2CriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = genderT2Criterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                //genderT1CriterionOperation,
                genderT2CriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to campaign " +
                        $"ID {campaignId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// The default keyword text.
        /// </summary>
        private const string KEYWORD_TEXT = "mars cruise";

        /// <summary>
        /// /
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="adGroupId"></param>
        /// <param name="is_search">whether to set the search text as POSITIVE or NEGATIVE keyword</param>
        /// <param name="search_text"></param>
        public static void addKeywordAdGroupCriterion(long customerId, long adGroupId, bool is_search, string search_text)
        {
            if (string.IsNullOrEmpty(search_text))
            {
                search_text = KEYWORD_TEXT;
            }
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V6.AdGroupCriterionService);

            //Create a keyword
            AdGroupCriterion keywordCriterion = buildKeywordAdGroupCriterion(customerId, adGroupId, is_search, search_text);

            AdGroupCriterionOperation keywordOperation =
                new AdGroupCriterionOperation()
                {
                    Create = keywordCriterion
                };

            AdGroupCriterionOperation[] operations = new AdGroupCriterionOperation[] {
                keywordOperation,
            };

            try
            {

                // Add the keywords.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                if (response.Results.Count > 0)
                {
                    foreach (MutateAdGroupCriterionResult newCriterion in response.Results)
                    {
                        Console.WriteLine($"Created keyword with resource ID = " +
                            $"'{newCriterion.ResourceName}'.");
                    }
                }
                else
                {
                    Console.WriteLine("No keywords were added.");
                }
            }

            /*
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V6.CampaignCriterionService);
            
            CampaignCriterion keywordCriterion = buildKeywordCampaignCriterion(customerId, campaignId, is_search, search_text);

            CampaignCriterionOperation keywordOperation =
                new CampaignCriterionOperation()
                {
                    Create = keywordCriterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                keywordOperation,
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to campaign " +
                        $"ID {campaignId}.\n");
                }
            }
            */

            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="locationIds">The list of location IDs to restrict the search.</param>
        /// <param name="languageId">The language to restrict the search.</param>
        /// <param name="keywordTexts">The list of seed keywords.</param>
        /// <param name="pageUrl">The seed page URL.</param>
        /// <param name="num_result">Number of results to be displayed</param>
        // [START GenerateKeywordIdeas]
        public static void GenerateKeywordIdeas(GoogleAdsClient client, long customerId, long[] locationIds,
            long languageId, string[] keywordTexts, string pageUrl, int num_result)
        {
            KeywordPlanIdeaServiceClient keywordPlanIdeaService =
                client.GetService(Services.V6.KeywordPlanIdeaService);

            // Make sure that keywords and/or page URL were specified. The request must have
            // exactly one of urlSeed, keywordSeed, or keywordAndUrlSeed set.
            if (keywordTexts.Length == 0 && string.IsNullOrEmpty(pageUrl))
            {
                throw new ArgumentException("At least one of keywords or page URL is required, " +
                    "but neither was specified.");
            }

            // Specify the optional arguments of the request as a keywordSeed, UrlSeed,
            // or KeywordAndUrlSeed.
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest()
            {
                CustomerId = customerId.ToString(),
            };

            if (keywordTexts.Length == 0)
            {
                // Only page URL was specified, so use a UrlSeed.
                request.UrlSeed = new UrlSeed()
                {
                    Url = pageUrl
                };
            }
            else if (string.IsNullOrEmpty(pageUrl))
            {
                // Only keywords were specified, so use a KeywordSeed.
                request.KeywordSeed = new KeywordSeed();
                request.KeywordSeed.Keywords.AddRange(keywordTexts);
            }
            else
            {
                // Both page URL and keywords were specified, so use a KeywordAndUrlSeed.
                request.KeywordAndUrlSeed = new KeywordAndUrlSeed();
                request.KeywordAndUrlSeed.Url = pageUrl;
                request.KeywordAndUrlSeed.Keywords.AddRange(keywordTexts);
            }


            // Create a list of geo target constants based on the resource name of specified
            // location IDs.
            foreach (long locationId in locationIds)
            {
                request.GeoTargetConstants.Add(ResourceNames.GeoTargetConstant(locationId));
            }

            request.Language = ResourceNames.LanguageConstant(languageId);
            // Set the network. To restrict to only Google Search, change the parameter below to
            // KeywordPlanNetwork.GoogleSearch.
            request.KeywordPlanNetwork = KeywordPlanNetwork.GoogleSearchAndPartners;

            try
            {
                // Generate keyword ideas based on the specified parameters.
                var response =
                    keywordPlanIdeaService.GenerateKeywordIdeas(request);

                List<string> listIdeaText = new List<string>();
                List<long> listAvgMonthlySearches = new List<long>();
                List<string> listCompetition = new List<string>();


                // Iterate over the results and print its detail.
                foreach (GenerateKeywordIdeaResult result in response)
                {
                    KeywordPlanHistoricalMetrics metrics = result.KeywordIdeaMetrics;
                    if (!(metrics == null))
                    {
                        /*
                        Console.WriteLine($"Keyword idea text '{result.Text}' has " +
                            $"{metrics.AvgMonthlySearches} average monthly searches and competition " +
                            $"is {metrics.Competition.ToString()}."
                        );
                        */
                        listIdeaText.Add(result.Text);
                        listAvgMonthlySearches.Add(metrics.AvgMonthlySearches);
                        listCompetition.Add(metrics.Competition.ToString());
                    }                   
                }
                //Generate dataframe
                var TextColumn = new StringDataFrameColumn("Text", listIdeaText);
                var AvgMonthlySearchColumn = new PrimitiveDataFrameColumn<long>("AvgMonthlySearch", listAvgMonthlySearches);
                var CompetitionColumn = new StringDataFrameColumn("Competition", listCompetition);

                //2. Create dataframe. This will fail if columns have different length
                var dataDf = new DataFrame(TextColumn, AvgMonthlySearchColumn, CompetitionColumn);

                //3. Sort by the AvgMonthlySearch Column
                DataFrame sorted = dataDf.OrderByDescending("AvgMonthlySearch");

                sorted.Head(num_result).PrettyPrint();

            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
        // [END GenerateKeywordIdeas]


        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The application's exit code.</returns>

        // If you simply want to try out a code example, you can create an instance of it here,
        // and call it's Run method. E.g.

        // Optional: If you have specified these keys in the App.config file, you can skip
        // creating a GoogleAdsConfig object and do
        // GoogleAdsClient googleAdsClient = new GoogleAdsClient();

        // string developerToken = "INSERT_YOUR_DEVELOPER_TOKEN_HERE";
        // string oAuth2clientId = "INSERT_OAUTH2_CLIENT_ID_HERE";
        // string oAuth2Secret = "INSERT_OAUTH2_CLIENT_SECRET_HERE";
        // string oAuth2RefreshToken = "INSERT_OAUTH2_REFRESH_TOKEN_HERE";
        // long loginCustomerId = long.Parse("INSERT_LOGIN_CUSTOMER_ID_HERE");

        // GoogleAdsConfig googleAdsConfig = new GoogleAdsConfig()
        // {
        //     DeveloperToken = developerToken,
        //     LoginCustomerId = loginCustomerId.ToString(),
        //     OAuth2ClientId = oAuth2clientId,
        //     OAuth2ClientSecret = oAuth2Secret,
        //     OAuth2RefreshToken = oAuth2RefreshToken,
        // };

        //GoogleAdsClient googleAdsClient = new GoogleAdsClient(googleAdsConfig);

        // Run the code example.
        // new V2.GetCampaigns().Run(new GoogleAdsClient(), 1234567890);

        // Alternatively, you can pass command line arguments to run the code example. E.g.
        // V2.GetCampaigns --customerId=1234567890
        // The first argument has the form VersionName.ExampleName, e.g. V2.GetCampaigns to run
        // Google.Ads.GoogleAds.Examples.V2.GetCampaigns example.
        // The subsequent arguments can be inferred by looking at the Run method of the code
        // example and skipping the first parameter.
        // E.g. GetCampaigns.cs has a Run method is defined as
        //
        //     public void Run(GoogleAdsClient client, long customerId)
        //
        // So, this example can be run with the command line arguments
        //
        //     V2.GetCampaigns --customerId=1234567890

        public static int Main(string[] args)
        {
            // Turn on detailed logging. This is useful for debugging your requests.
            // You should also replace INSERT_PATH_TO_DETAILED_LOGS_HERE to a file path that will
            // be used to write the detailed logs to. E.g. C:\\logs\\details.log
            // Detailed logs.
            TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                "C:\\Users\\Powell\\Documents\\GitHub\\google-ads-dotnet\\examples\\details.log", System.Diagnostics.SourceLevels.All);
            // Summary logs.
            TraceUtilities.Configure(TraceUtilities.SUMMARY_REQUEST_LOGS_SOURCE,
                "C:\\Users\\Powell\\Documents\\GitHub\\google-ads-dotnet\\examples\\summary.log", System.Diagnostics.SourceLevels.All);


            // If the API log doesn't give you enough details, then you can enable more low level
            // logging at grpc level. Keep in mind that this can get pretty detailed and long. The
            // grpc logs are written to stderr.
            // You can find all the supported environment variables here:
            // https://github.com/grpc/grpc/blob/master/doc/environment_variables.md

            //Environment.SetEnvironmentVariable("GRPC_VERBOSITY", "DEBUG");
            //Environment.SetEnvironmentVariable("GRPC_TRACE", "http");

            long customerId = 2666127839;

            //-pchu1a: Examples
            //new V6.GetCampaigns().Run(new GoogleAdsClient(), 2666127839);

            //-pchu1b: Get Campaign Info
            //getCampaignInfo(customerId);

            //-pchu2: Get campaign criteria
            //new V6.GetCampaignTargetingCriteria().Run(new GoogleAdsClient(), 2666127839, 12429579081);

            //-pchu3: Look up Location 'Constant' by name
            new V6.GetGeoTargetConstantsByNames().Run(new GoogleAdsClient());
            /* result:
             * ex.1: "Richmond Hill":
             * geoTargetConstants/1002405 (Richmond Hill, CA, City, Enabled) is found in locale (en) 
            with reach (542000) for search term (Richmond Hill).
             * ex.2: "M2N":
             * geoTargetConstants/9000914 (M2N, CA, Postal Code, Enabled) is found in locale (en) with reach (663000) for search term (M2N).
             */


            //-pchu4: Add Campaign Criterion: Geo
            //long campaignId = 12429579081;
            //long locationId = 1002405;       //obtained from pchu3: Richmond Hill, CA
            //addGeoTargetLocationCriterion(customerId, campaignId, locationId);
            //new V6.AddCampaignTargetingCriteria().Run(new GoogleAdsClient(), customerId, campaignId, "temp", locationId);

            //-pchu5: Target campaigns for proximity to a location
            //https://developers.google.com/google-ads/api/docs/targeting/location-targeting#c

            //-pchu6: retrieve campaign geo target location
            long campaignId = 12429579081;
            getGeoTarget(customerId, campaignId);

            //-pchu7: Add Age Range Criterion
            //long campaignId = 12429579081;
            //addAgeRangeCriterion(customerId, campaignId);

            //-pchu8: Add Gender Criterion
            //long campaignId = 12429579081;
            //addGenderCriterion(customerId, campaignId);

            //-pchu9: Add Keyword Criterion (to Ad Group! Can also do it to Campaign)
            /*
            long adGroupId = 121290976922;
            string insert_word = "Baseball";
            addKeywordAdGroupCriterion(customerId, adGroupId, false, insert_word);
            */
            //-or run this: new V6.AddKeywords().Run(new GoogleAdsClient(), customerId, adGroupId, insert_word);

            //-pchu9b: trying to add keyword by FIRST add ad group in coding
            //long campaignId = 12429579081;
            //new V6.AddAdGroups().Run(new GoogleAdsClient(), customerId, campaignId);
            /*
            long adGroupId = 117064170462;
            string insert_word = "Baseball";
            new V6.AddKeywords().Run(new GoogleAdsClient(), customerId, adGroupId, insert_word);
            */


            //-pchu10: retrieve campaign Audience Age / Gender Info
            //long campaignId = 12429579081;
            //getAudienceInfo(customerId, campaignId);

            //-pchu11: retreive campaign Keyword info
            //getCampaignKeywordsInfo(customerId);

            //-pchu12: retrieve adgroup keyword info
            //getAdGroupAdInfo(customerId);

            //-pchu13: checking out GenerateKeywordIdeas.cs
            /*
            long[] list_locationId = { 1002405 };       //obtained from pchu3: Richmond Hill, CA
            long languageId = 1000;
            string[] list_insert_word = { "Basketball" };
            new V6.GenerateKeywordIdeas().Run(new GoogleAdsClient(), customerId, list_locationId, languageId, list_insert_word, "");
            */

            //-pchu13b: create own method --> sort --> pick top '10' keywords
            /*
            long[] list_locationId = { 1002405 };       //obtained from pchu3: Richmond Hill, CA
            long languageId = 1000;
            string[] list_insert_word = { "Basketball" };
            string pageUrl = "";
            int num_result = 10;
            GenerateKeywordIdeas(new GoogleAdsClient(), customerId, list_locationId, languageId, list_insert_word, pageUrl, num_result);
            */

            //-pchu14: testing custom interest info:
            /*
            long adGroupId = 121290976922;
            string interest = "Baseball";
            AdGroupCriterion test =  buildCustomInterestCriterion(customerId, adGroupId, interest);

            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            AdGroupCriterionServiceClient AdGroupCriterionService =
                client.GetService(Services.V6.AdGroupCriterionService);

            AdGroupCriterionOperation cusInterestCriterionOperation =
                 new AdGroupCriterionOperation()
                 {
                     Create = test
                 };

            AdGroupCriterionOperation[] operations = new AdGroupCriterionOperation[] {
                cusInterestCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateAdGroupCriteriaResponse response =
                    AdGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateAdGroupCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew AdGroup criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to AdGroup " +
                        $"ID {adGroupId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            */

            return RunExamplesFromCommandLineArguments(args);
        }

        /// <summary>
        /// Runs the examples from command line arguments.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The application's exit code. The valid return codes are:
        /// /// <list type="bullet">
        /// <item><description>0. The code example ran successfully.</description></item>
        /// <item><description>1. The code example threw an exception and did not complete
        /// successfully.</description></item>
        /// <item><description>2. The application was invoked with an incorrect command line
        /// argument.</description></item>
        /// </list>
        /// </returns>
        private static int RunExamplesFromCommandLineArguments(string[] args)
        {
            ExampleRunner runner = new ExampleRunner();
            runner.LoadCodeExamples(Assembly.GetExecutingAssembly());

            if (args.Length == 0)
            {
                // Bad command line parameter.
                ShowUsage(runner);
                return 2;
            }

            GoogleAdsClient session = new GoogleAdsClient();
            string exampleName = args[0];
            try
            {
                // Optional: Turn on profiling to see how long an API call takes.
                // runner.RunWithProfiling(exampleName, session, args);
                runner.Run(exampleName, session, args.Skip(1));
                return 0;
            }
            catch (TargetInvocationException)
            {
                // Indicates a failure due to an unhandled exception.
                return 1;
            }
            catch (Exception e) when (e is KeyNotFoundException || e is ArgumentException ||
               e is TargetParameterCountException)
            {
                // Bad command line parameter.
                // Note: There are a couple more exceptions that the runner may throw, but all
                // those indicate a failure with the runner implementation than a code example
                // failure.
                ShowUsage(runner);
                return 2;
            }
        }

        /// <summary>
        /// Prints program usage message.
        /// </summary>
        private static void ShowUsage(ExampleRunner runner)
        {
            string exeName = ExampleRunner.GetExecutableName();
            //Console.WriteLine("Runs Google Ads API code examples");
            //Console.WriteLine("Usage : dotnet {0} examplename [flags]\n", exeName);
            //Console.WriteLine($"Supported examples: \n");
            //runner.PrintAvailableExamples();
            Console.WriteLine("Press [Enter] to continue");
            Console.ReadLine();
        }
    }
}
