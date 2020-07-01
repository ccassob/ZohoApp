using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZohoApp.App;

namespace ZohoApp.TestApp
{
    [TestClass]
    public class TransformHistoryTest
    {
        [TestMethod]
        public void TestTransform_BeginAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Iniciando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.Begin
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("WhiteSpace")]
        public void TestTransform_BeginAction_WithRightSpace()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Iniciando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía     ";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.Begin
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [TestCategory("WhiteSpace")]
        public void TestTransform_BeginAction_WithHistoryLeftSpace()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Iniciando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "             5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.Begin
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("WhiteSpace")]
        public void TestTransform_BeginAction_WithTask1LeftSpace()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Iniciando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "     desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.Begin
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("WhiteSpace")]
        public void TestTransform_BeginAction_WithTask1RightSpace()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Iniciando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita       ";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.Begin
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTransform_ContinueAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Continuando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.Continue
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTransform_EndAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Terminando de trabajar en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.End
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTransform_BadHistoryText()
        {
            //Arrange
            const string expected = "Parameter name: HistoryText";

            ITransformHistory transform = new TransformHistory();
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = string.Empty,
                FirstTask = task1,
                Actions = Actions.End
            };

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => transform.Transform(transformHistoryDto), expected);
        }

        [TestMethod]
        [TestCategory("FirstTask")]
        public void TestTransform_BadTask1Text()
        {
            //Arrange
            const string expected = "Parameter name: Task1Text";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = string.Empty,
                Actions = Actions.End
            };

            //Assert.
            Assert.ThrowsException<ArgumentNullException>(() => transform.Transform(transformHistoryDto), expected);
        }

        [TestMethod]
        [TestCategory("Actions")]
        public void TestTransform_NoneAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Estuve trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                Actions = Actions.None
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("SecondTask")]
        public void TestTransform_Task2_BeginAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Iniciando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita y además estuve trabajando en desarrollar cambios para que pueda cancelar cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";
            string task2 = "desarrollar cambios para que pueda cancelar cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                SecondTask = task2,
                Actions = Actions.Begin
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("SecondTask")]
        public void TestTransform_Task2_ContinueAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Continuando trabajando en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita y además estuve trabajando en desarrollar cambios para que pueda cancelar cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";
            string task2 = "desarrollar cambios para que pueda cancelar cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                SecondTask = task2,
                Actions = Actions.Continue
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("SecondTask")]
        public void TestTransform_Task2_EndAction()
        {
            //Arrange
            string expected = "Estuve trabajando con la historia 5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía. Terminando de trabajar en desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita y además estuve trabajando en desarrollar cambios para que pueda cancelar cita.";

            ITransformHistory transform = new TransformHistory();
            string history = "5587: Integración Colecturía Digital - Consulta de Estatus de Citas para Colecturía";
            string task1 = "desarrollar cambios para que colecturía pueda ver el estatus de las citas al enviarle un numero de cita";
            string task2 = "desarrollar cambios para que pueda cancelar cita";

            //Act
            var transformHistoryDto = new TransformHistoryDto()
            {
                History = history,
                FirstTask = task1,
                SecondTask = task2,
                Actions = Actions.End
            };

            string result = transform.Transform(transformHistoryDto);

            //Assert.
            Assert.AreEqual(expected, result);
        }
    }
}