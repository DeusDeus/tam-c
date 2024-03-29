using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using EnvDTE;
using EnvDTE80;
using Extensibility;
using Microsoft.VisualStudio.CommandBars;
using Wizard.Formularios;

namespace Wizard
{
	/// <summary>Objeto para implementar un complemento.</summary>
	/// <seealso class='IDTExtensibility2' />
	public class Connect : IDTExtensibility2, IDTCommandTarget
	{
        private DTE2 _applicationObject;
        private AddIn _addInInstance;
        private frmWizardPag1 objWizardPag1 = null;

        /// <summary>Implementa el constructor para el objeto del complemento. Coloque el código de inicialización en este método.</summary>
		public Connect()
		{
		}

		/// <summary>Implementa el método OnConnection de la interfaz IDTExtensibility2. Recibe la notificación de carga del complemento.</summary>
		/// <param term='application'>Objeto raíz de la aplicación host.</param>
		/// <param term='connectMode'>Describe cómo se carga el complemento.</param>
		/// <param term='addInInst'>Objeto que representa a este complemento.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
		{
			_applicationObject = (DTE2)application;
			_addInInstance = (AddIn)addInInst;
			if(connectMode == ext_ConnectMode.ext_cm_UISetup)
			{
				object []contextGUIDS = new object[] { };
				Commands2 commands = (Commands2)_applicationObject.Commands;
				string toolsMenuName;

				try
				{
					//Si desea mover el comando a un menú diferente, cambie la palabra "Herramientas" a 
					//  la versión en inglés del menú. Este código adaptará la referencia cultural, la agregará al nombre del menú
					//  y agregará el comando a dicho menú. Encontrará una lista de todos los menús de nivel superior en el archivo
					//  CommandBar.resx.
					string resourceName;
					ResourceManager resourceManager = new ResourceManager("Wizard.CommandBar", Assembly.GetExecutingAssembly());
					CultureInfo cultureInfo = new CultureInfo(_applicationObject.LocaleID);
					
					if(cultureInfo.TwoLetterISOLanguageName == "zh")
					{
						System.Globalization.CultureInfo parentCultureInfo = cultureInfo.Parent;
						resourceName = String.Concat(parentCultureInfo.Name, "Tools");
					}
					else
					{
						resourceName = String.Concat(cultureInfo.TwoLetterISOLanguageName, "Tools");
					}
					toolsMenuName = resourceManager.GetString(resourceName);
				}
				catch
				{
					//Hemos intentado encontrar una versión localizada de la palabra Tools, pero no se ha encontrado.
					//  Predeterminado para la palabra en inglés de Estados Unidos, que puede funcionar para la referencia cultural actual.
					toolsMenuName = "Tools";
				}

				//Coloque el comando en el menú Herramientas.
				//Encuentre la barra de comandos MenuBar, que es la barra de comandos del nivel superior que contiene todos los elementos de menú principales:
				Microsoft.VisualStudio.CommandBars.CommandBar menuBarCommandBar = ((Microsoft.VisualStudio.CommandBars.CommandBars)_applicationObject.CommandBars)["MenuBar"];

				//Encuentre la barra de comandos Herramientas en la barra de comandos MenuBar:
				CommandBarControl toolsControl = menuBarCommandBar.Controls[toolsMenuName];
				CommandBarPopup toolsPopup = (CommandBarPopup)toolsControl;

				//Este bloque try/catch puede duplicarse si desea agregar varios comandos para que los controle el complemento;
				//  asegúrese de actualizar también el método QueryStatus/Exec para incluir los nuevos nombres de comando.
				try
				{
					//Agregue un comando a la colección de comandos:
					Command command = commands.AddNamedCommand2(_addInInstance, "Wizard", "Wizard", "Executes the command for Wizard", true, 59, ref contextGUIDS, (int)vsCommandStatus.vsCommandStatusSupported+(int)vsCommandStatus.vsCommandStatusEnabled, (int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton);

					//Agregue un control para el comando en el menú Herramientas:
					if((command != null) && (toolsPopup != null))
					{
						command.AddControl(toolsPopup.CommandBar, 1);
					}
				}
				catch(System.ArgumentException)
				{
					//Si estamos aquí, probablemente la excepción se deba a que ya existe
					//  un comando con dicho nombre. Si es así no habrá que volver a crear el comando y podremos 
                    //  omitir la excepción.
				}
			}
		}

		/// <summary>Implementa el método OnDisconnection de la interfaz IDTExtensibility2. Recibe la notificación de descarga del complemento.</summary>
		/// <param term='disconnectMode'>Describe cómo se descarga el complemento.</param>
		/// <param term='custom'>Matriz de parámetros específicos de la aplicación host.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
		{
		}

		/// <summary>Implementa el método OnAddInsUpdate de la interfaz IDTExtensibility2. Recibe una notificación cuando cambia la colección de complementos.</summary>
		/// <param term='custom'>Matriz de parámetros específicos de la aplicación host.</param>
		/// <seealso class='IDTExtensibility2' />		
		public void OnAddInsUpdate(ref Array custom)
		{
		}

		/// <summary>Implementa el método OnStartupComplete de la interfaz IDTExtensibility2. Recibe una notificación de que la aplicación host se ha cargado completamente.</summary>
		/// <param term='custom'>Matriz de parámetros específicos de la aplicación host.</param>
		/// <seealso class='IDTExtensibility2' />
        public void OnStartupComplete(ref Array custom)
		{
		}

		/// <summary>Implementa el método OnBeginShutdown de la interfaz IDTExtensibility2. Recibe notificación de la descarga de la aplicación host.</summary>
		/// <param term='custom'>Matriz de parámetros específicos de la aplicación host.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnBeginShutdown(ref Array custom)
		{
		}
		
		/// <summary>Implementa el método QueryStatus de la interfaz IDTCommandTarget. Se llama a este método cuando se actualiza la disponibilidad del comando</summary>
		/// <param term='commandName'>Nombre del comando cuyo estado se va a determinar.</param>
		/// <param term='neededText'>Texto necesario para el comando.</param>
		/// <param term='status'>Estado del comando en la interfaz de usuario.</param>
		/// <param term='commandText'>Texto requerido por el parámetro neededText.</param>
		/// <seealso class='Exec' />
		public void QueryStatus(string commandName, vsCommandStatusTextWanted neededText, ref vsCommandStatus status, ref object commandText)
		{
			if(neededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone)
			{
				if(commandName == "Wizard.Connect.Wizard")
				{
					status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported|vsCommandStatus.vsCommandStatusEnabled;
					return;
				}
			}
		}

		/// <summary>Implementa el método Exec de la interfaz IDTCommandTarget. Se llama a este método cuando se invoca al comando.</summary>
		/// <param term='commandName'>El nombre del comando que se va a ejecutar.</param>
		/// <param term='executeOption'>Describe cómo debería ejecutarse el comando.</param>
		/// <param term='varIn'>Parámetros que se pasan desde el llamador hasta el controlador de comandos.</param>
		/// <param term='varOut'>Parámetros que se pasan desde el controlador de comandos hasta el llamador.</param>
		/// <param term='handled'>Informa al llamador de si se ha controlado o no el comando.</param>
		/// <seealso class='Exec' />
		public void Exec(string commandName, vsCommandExecOption executeOption, ref object varIn, ref object varOut, ref bool handled)
		{
            handled = false;
			if(executeOption == vsCommandExecOption.vsCommandExecOptionDoDefault)
			{
				if(commandName == "Wizard.Connect.Wizard")
				{
                    if (objWizardPag1 == null)
                    {
                        objWizardPag1 = new frmWizardPag1(this);
                        objWizardPag1.Show();
                    }
                    
                    handled = true;
                    return;
				}
			}
		}

        /// <summary>Método agregado por el desarrollador. Restea la variable objWizardPag1.</summary>
        public void Reset()
        {
            objWizardPag1 = null;
        }

        /// <summary>Método agregado por el desarrollador. Obtiene los modulos del proyecto.</summary>
        public List<string> ObtenerModulos()
        {
            Array arrProyectos;
            Project proyecto;
            List<string> lstModulos = new List<string>();

            arrProyectos = (Array)_applicationObject.ActiveSolutionProjects;
            proyecto = (Project)arrProyectos.GetValue(0);

            foreach (ProjectItem p in proyecto.ProjectItems)
            {
                switch (p.Name)
                {
                    case "Properties": 
                        //No hace nada
                        break;
                    case "SpectrumFondos.cs": 
                        //No hace nada
                        break;
                    default:
                        lstModulos.Add(p.Name);
                        break;
                };
            }

            return lstModulos;
        }

        /// <summary>Método agregado por el desarrollador. Obtiene los formularios de un proyecto.</summary>
        /// <param term='pstrNombreModulo'>El nombre del modulo donde se encuentran los formularios.</param>
        public List<ProjectItem> ObtenerFormularios(string pstrNombreModulo)
        {
            Array arrProyectos;
            Project proyecto;
            ProjectItem item = null;
            List<ProjectItem> lstFormularios = new List<ProjectItem>();
            bool encontro = false;

            arrProyectos = (Array)_applicationObject.ActiveSolutionProjects;
            proyecto = (Project)arrProyectos.GetValue(0);

            foreach (ProjectItem p in proyecto.ProjectItems)
            {
                switch (p.Name)
                {
                    case "Properties":
                        //No hace nada
                        break;
                    case "SpectrumFondos.cs":
                        //No hace nada 
                        break;
                    default:
                        if (p.Name.CompareTo(pstrNombreModulo) == 0)
                        {
                            foreach (ProjectItem pitem in p.ProjectItems)
                            {
                                item = pitem;
                            }
                            encontro = true;
                        }
                        break;
                };

                if (encontro) break;
            }

            foreach (ProjectItem pitem in item.ProjectItems)
            {
                lstFormularios.Add(pitem);
            }

            return lstFormularios;
        }
    }
}