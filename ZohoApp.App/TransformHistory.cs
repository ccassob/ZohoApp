using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApp.App
{
    public class TransformHistory : ITransformHistory
    {
        public string Transform(TransformHistoryDto transformHistoryDto)
        {
            if (string.IsNullOrEmpty(transformHistoryDto.History))
            {
                throw new ArgumentNullException(nameof(transformHistoryDto.History));
            }

            if (string.IsNullOrEmpty(transformHistoryDto.FirstTask))
            {
                throw new ArgumentNullException(nameof(transformHistoryDto.FirstTask));
            }

            string result = $"Estuve trabajando con la historia {transformHistoryDto.History.Trim()}. ";

            if (transformHistoryDto.Actions == Actions.Begin)
            {
                if (string.IsNullOrEmpty(transformHistoryDto.SecondTask))
                {
                    result += $"Iniciando trabajando en {transformHistoryDto.FirstTask.TrimEnd('.').Trim()}.";
                }
                else
                {
                    result += $"Iniciando trabajando en {transformHistoryDto.FirstTask.Trim()} y además estuve trabajando en {transformHistoryDto.SecondTask.TrimEnd('.').Trim()}.";
                }
            }
            else if (transformHistoryDto.Actions == Actions.Continue)
            {
                if (string.IsNullOrEmpty(transformHistoryDto.SecondTask))
                {
                    result += $"Continuando trabajando en {transformHistoryDto.FirstTask.TrimEnd('.').Trim()}.";
                }
                else
                {
                    result += $"Continuando trabajando en {transformHistoryDto.FirstTask.Trim()} y además estuve trabajando en {transformHistoryDto.SecondTask.TrimEnd('.').Trim()}.";
                }
            }
            else if (transformHistoryDto.Actions == Actions.End)
            {
                if (string.IsNullOrEmpty(transformHistoryDto.SecondTask))
                {
                    result += $"Terminando de trabajar en {transformHistoryDto.FirstTask.TrimEnd('.').Trim()}.";
                }
                else
                {
                    result += $"Terminando de trabajar en {transformHistoryDto.FirstTask.Trim()} y además estuve trabajando en {transformHistoryDto.SecondTask.TrimEnd('.').Trim()}.";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(transformHistoryDto.SecondTask))
                {
                    result += $"Estuve trabajando en {transformHistoryDto.FirstTask.TrimEnd('.').Trim()}.";
                }
                else
                {
                    result += $"Estuve trabajando en {transformHistoryDto.FirstTask.Trim()} y además estuve trabajando en {transformHistoryDto.SecondTask.TrimEnd('.').Trim()}.";
                }
            }

            return result;
        }
    }
}