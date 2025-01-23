using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeRabbitTestSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private void names()
        {
            var var1 = 1;
            var var2 = "ff";

            var veeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeryLongNaem = "ff2";

        }

        private float tosTRING(decimal num1)
        {
            return (float)num1;
        }

        //the most useless comment
        private void GOODNAME__EXAMPLE()
        {
            
        }

        // this method calls an api to get list of users
        private IEnumerable<int> getSomeNumbers()
        {
            return new List<int>() { 1, 2, 3 };
        }

        private void formatting()
                                                                            {
                                                                                string sum = "0";

                                                                                string suum2 = "1" + "2";

                                                                            }

        private string getSuperSecretApiKey()
        {
            var importantApiKey = "FDW123FDS543VSDDAD.KEY";
            return importantApiKey;
        }

        private void spaghetti()
        {
            if (true)
            {
                if (true)
                {
                    if (true)
                    {
                        if (true)
                        {
                            if (true)
                            {
                                if (true)
                                {
                                    if (true)
                                    {
                                        if (true)
                                        {
                                            if (true)
                                            {
                                                if (true)
                                                {
                                                    if (true)
                                                    {
                                                        if (true)
                                                        {
                                                            if (true)
                                                            {
                                                                if (true)
                                                                {
                                                                    if (true)
                                                                    {
                                                                        if (true)
                                                                        {
                                                                            if (true)
                                                                            {
                                                                                if (true)
                                                                                {
                                                                                    if (true)
                                                                                    {
                                                                                        if (true)
                                                                                        {
                                                                                            Console.WriteLine("finish");
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private string importantCalculations()
        {
            var sum = (1 + 3 + 2.3435) / 55;
            return sum;
        }

        private string func1()
        {
            return """
                   function reallyBigFunction(){
                       handleCancelModalRemove();
                       let tempStatus = 1;
                       const buttonName = data.target.innerText;
                       if (buttonName) {
                           if (buttonName.includes(draft)) {
                               tempStatus = 0;
                               setSavedChanges(true);
                           }
                       }
                       form.validateFields()
                           .then(() => {
                               data.stopPropagation();
                   
                               let subtitles: SubtitleCreate[] = [];
                               if (subTitle != null && subTitle.subtitleText) {
                                   subtitles = [
                                       { subtitleText: subTitle!.subtitleText },
                                   ];
                               }
                               let videos: VideoCreate[] = [];
                               if (inputInfo != null && inputInfo.link) {
                                   videos = [{ url: inputInfo.link }];
                               }
                   
                               const text: TextCreateUpdate = {
                                   id: inputInfo?.id ?? 0,
                                   title: inputInfo?.title,
                                   textContent: inputInfo?.textContent ?? ' ',
                                   additionalText:
                                       inputInfo?.textContent !== '<p><br></p>'
                                           ? inputInfo?.additionalText
                                           === '<p>Текст підготовлений спільно з</p>'
                                               ? ''
                                               : inputInfo?.additionalText
                                           : '',
                                   streetcodeId: parseId,
                               };
                               validateQuillTexts(text.textContent, text.additionalText);
                   
                               const streetcode: StreetcodeCreate = {
                                   id: parseId,
                                   index: form.getFieldValue('streetcodeNumber'),
                                   title: form.getFieldValue('mainTitle'),
                                   alias: form.getFieldValue('alias'),
                                   transliterationUrl: form.getFieldValue('streetcodeUrlName'),
                                   arBlockURL: form.getFieldValue('url'),
                                   streetcodeType: streetcodeType.current,
                                   eventStartOrPersonBirthDate: dayjs
                                       .utc(form.getFieldValue('streetcodeFirstDate'))
                                       .toDate(),
                                   eventEndOrPersonDeathDate: form.getFieldValue(
                                       'streetcodeSecondDate',
                                   )
                                       ? dayjs
                                           .utc(form.getFieldValue('streetcodeSecondDate'))
                                           .toDate()
                                       : null,
                                   imagesIds: createUpdateMediaStore.getImageIds(),
                                   audioId: createUpdateMediaStore.audioId,
                                   tags: reindex(selectedTags).map((tag) => ({
                                       ...tag,
                                       id: tag.id < 0 ? 0 : tag.id,
                                   })),
                                   relatedFigures: figures,
                                   text: text.title && text.textContent ? text : null,
                                   timelineItems:
                                   timelineItemStore.getTimelineItemArrayToCreate,
                                   facts: reindex(
                                       JSON.parse(JSON.stringify(factsStore.getFactArray)).map(
                                           (fact: Fact) => ({ ...fact, id: 0 }),
                                       ),
                                   ),
                                   coordinates: JSON.parse(
                                       JSON.stringify(
                                           streetcodeCoordinatesStore.getStreetcodeCoordinateArray,
                                       ),
                                   ).map((coordinate: StreetcodeCoordinate) => ({
                                       ...coordinate,
                                       id: 0,
                                   })),
                                   partners: partners.map((partner) => partner.id),
                                   teaser: form.getFieldValue('teaser'),
                                   viewCount: 0,
                                   dateString: form.getFieldValue('dateString'),
                                   arts: artStore.arts,
                                   streetcodeArtSlides:
                                       streetcodeArtSlideStore.getArtSlidesAsDTO(),
                                   subtitles,
                                   firstName: null,
                                   lastName: null,
                                   videos,
                                   status: tempStatus,
                                   toponyms: newStreetcodeInfoStore.selectedToponyms,
                                   streetcodeCategoryContents: JSON.parse(
                                       JSON.stringify(
                                           sourceCreateUpdateStreetcode.streetcodeCategoryContents,
                                       ),
                                   ).map(
                                       (
                                           streetcodeCategoryContent: StreetcodeCategoryContent,
                                       ) => ({
                                           ...streetcodeCategoryContent,
                                           id: 0,
                                       }),
                                   ),
                                   statisticRecords: JSON.parse(
                                       JSON.stringify(
                                           statisticRecordStore.getStatisticRecordArray,
                                       ),
                                   ).map((statisticRecord: StatisticRecord) => ({
                                       ...statisticRecord,
                                       id: 0,
                                       coordinateId: 0,
                                       streetcodeCoordinate: {
                                           ...statisticRecord.streetcodeCoordinate,
                                           id: 0,
                                       },
                                   })),
                                   imagesDetails: createUpdateMediaStore.getImageDetails(),
                               };
                   
                               if (streetcodeType.current === StreetcodeType.Person) {
                                   streetcode.firstName = form.getFieldValue('name');
                                   streetcode.lastName = form.getFieldValue('surname');
                               }
                               if (parseId) {
                                   const relatedFiguresUpdate: RelatedFigureUpdate[] = figures.map((figure) => ({
                                       observerId: parseId,
                                       targetId: figure.id,
                                       modelState: figure.modelState,
                                   }));
                   
                                   const partnersUpdate: PartnerUpdate[] = partners.map(
                                       (partner) => ({
                                           streetcodeId: parseId,
                                           partnerId: partner.id,
                                           modelState: partner.modelState,
                                       }),
                                   );
                   
                                   let videosUpdate: Video[] = [];
                                   if (inputInfo != null && inputInfo.link) {
                                       videosUpdate = [{ ...video, url: inputInfo.link } as Video];
                                   }
                                   let subtitleUpdate: Subtitle[] = [];
                                   if (subTitle != null && subTitle.subtitleText) {
                                       subtitleUpdate = [{ ...subTitle, subtitleText: subTitle!.subtitleText } as Subtitle];
                                   }
                   
                                   const tags = [
                                       ...(reindex(selectedTags) as StreetcodeTagUpdate[]).map(
                                           (tag) => ({
                                               ...tag,
                                               streetcodeId: parseId,
                                           }),
                                       ),
                                       ...tagsStore.getTagToDeleteArray,
                                   ];
                   
                                   const arUrl = form.getFieldValue('url');
                                   let urlUpdated: string | null = url;
                                   if (!arUrl) {
                                       urlUpdated = null;
                                   }
                   
                                   if (text.id !== 0 && !text.title) {
                                       text.modelState = ModelState.Deleted;
                                   }
                   
                                   const streetcodeUpdate: StreetcodeUpdate = {
                                       id: parseId,
                                       index: form.getFieldValue('streetcodeNumber'),
                                       firstName: null,
                                       lastName: null,
                                       title: form.getFieldValue('mainTitle'),
                                       alias: form.getFieldValue('alias'),
                                       status: tempStatus,
                                       transliterationUrl: form.getFieldValue('streetcodeUrlName'),
                                       streetcodeType: streetcodeType.current,
                                       eventStartOrPersonBirthDate: dayjs.utc(form.getFieldValue('streetcodeFirstDate')).toDate(),
                                       eventEndOrPersonDeathDate: form.getFieldValue('streetcodeSecondDate')
                                           ? dayjs.utc(form.getFieldValue('streetcodeSecondDate')).toDate() : null,
                                       teaser: form.getFieldValue('teaser'),
                                       dateString: form.getFieldValue('dateString'),
                                       videos: videosUpdate,
                                       relatedFigures: relatedFiguresUpdate,
                                       timelineItems: timelineItemStore.getTimelineItemArrayToUpdate,
                                       facts: reindex(factsStore.getFactArrayToUpdate.map((item) => ({ ...item,
                                           streetcodeId: parseId,
                                           id: item.id < 0 ? 0 : item.id }))),
                                       partners: partnersUpdate,
                                       subtitles: subtitleUpdate,
                                       text: text.modelState === ModelState.Deleted || text.title ? text : null,
                                       streetcodeCategoryContents: sourceCreateUpdateStreetcode.getCategoryContentsArrayToUpdate
                                           .map((content) => ({ ...content, streetcodeId: parseId })),
                                       arts: artStore.arts,
                                       streetcodeArtSlides: streetcodeArtSlideStore.getArtSlidesAsDTO(),
                                       tags: tags.map((tag) => ({ ...tag, id: tag.id < 0 ? 0 : tag.id })),
                                       statisticRecords: statisticRecordStore.getStatisticRecordArrayToUpdate
                                           .map((record) => ({ ...record, streetcodeId: parseId })),
                                       toponyms: newStreetcodeInfoStore.selectedToponyms,
                                       images: createUpdateMediaStore.imagesUpdate.map((img): ImageCreateUpdate => ({ id: img.id, modelState: img.modelState, streetcodeId: img.streetcodeId })),
                                       audioId: createUpdateMediaStore.audioId,
                                       audios: createUpdateMediaStore.audioUpdate.map((a): AudioUpdate => ({ id: a.id, modelState: a.modelState, streetcodeId: a.streetcodeId })),
                                       arBlockURL: form.getFieldValue('url'),
                                       imagesDetails: (Array.from(factsStore.factImageDetailsMap.values()) as ImageDetails[]).concat(createUpdateMediaStore.getImageDetailsUpdate()),
                                   };
                   
                                   if (streetcodeType.current === StreetcodeType.Person) {
                                       streetcodeUpdate.firstName = form.getFieldValue('name');
                                       streetcodeUpdate.lastName = form.getFieldValue('surname');
                                   }
                                   StreetcodesApi.update(streetcodeUpdate)
                                       .then(() => {
                                           window.location.reload();
                                       })
                                       .then(() => {
                                           alert('History-код успішно оновлений');
                                       })
                                       .catch((error) => {
                                           alert('Виникла помилка при оновленні history-коду');
                                           console.error(error);
                                       });
                               } else {
                                   StreetcodesApi.create(streetcode)
                                       .then(() => {
                                           streetcodeArtSlideStore.streetcodeArtSlides = [];
                                           if (tempStatus === 1) {
                                               navigate(
                                                   `../${form.getFieldValue(
                                                       'streetcodeUrlName',
                                                   )}`,
                                                   {
                                                       replace: true,
                                                   },
                                               );
                                           } else {
                                               navigate(
                                                   `${
                                                       FRONTEND_ROUTES.ADMIN.BASE
                                                   }/${form.getFieldValue(
                                                       'streetcodeUrlName',
                                                   )}`,
                                               );
                                           }
                                       })
                                       .catch((error) => {
                                           alert('Виникла помилка при створенні history-коду');
                                           console.error(error);
                                       });
                               }
                           })
                           .catch((error) => {
                               const name = form
                                   .getFieldsError()
                                   .find((e) => e.errors.length > 0)?.name;
                               if (name) {
                                   scrollToErrors();
                               } else {
                                   alert('Будь ласка, заповніть всі поля валідними даними');
                                   console.error(error);
                               }
                           });
                   };
                                      
                   """;
        }

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public class Class1
        {
            public decimal Calculate(decimal amount, int type, int years)
            {
                decimal result = 0;
                decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
                if (type == 1)
                {
                    result = amount;
                }
                else if (type == 2)
                {
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                }
                else if (type == 3)
                {
                    result = (0.7m * amount) - disc * (0.7m * amount);
                }
                else if (type == 4)
                {
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                }
                return result;
            }
        }
    }
}
