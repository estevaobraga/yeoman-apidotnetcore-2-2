var Generator = require("yeoman-generator");
const rename = require("gulp-rename");

module.exports = class extends Generator {
  // Configurations will be loaded here.
  // Ask for user input
  async prompting() {
    this.answers = await this.prompt([
      {
        type: "input",
        name: "name",
        message: "Nome do seu projeto",
        default: this.appname // Default to current folder name
      }
    ]);

    this.log("app name", this.answers.name);
  }

  // Writing Logic here
  writing() {
    var nomeProj = this.answers.name;

    this.registerTransformStream(
      rename(function(path) {
        path.basename = path.basename.replace(/(apimodelo.netcore)/g, nomeProj);
        path.dirname = path.dirname.replace(/(apimodelo.netcore)/g, nomeProj);
        return path;
      })
    );

    this.fs.copyTpl(this.templatePath(), this.answers.name, {
      nomeProj: nomeProj
    });
  }

  end() {
    this.log(
      "Projeto criado com sucesso, use os camandos abaixo para continuar..."
    );
    this.log('    cd "' + this.options.applicationName + '"');
    this.log("    dotnet restore");
  }
};
