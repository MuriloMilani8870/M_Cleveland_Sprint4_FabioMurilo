import React, { Component } from 'react';
import { Text, View, } from 'react-native';
import { FlatList } from 'react-native-gesture-handler';

class Home extends Component {

  constructor(props) {
    super(props);
    this.state = {
      medicos: [],
    };
  }

  componentDidMount() {
    this._carregarMedicos();
  }

  _carregarMedicos = async () => {
    await fetch('http://192.168.6.220:5000/Api/Medicos')
      .then(response => response.json())
      .then(data => this.setState({ medicos: data }))
      .catch(erro => console.warn(erro));
    console.log(medicos)
  };

  render() {
    return (
      <View>
        <FlatList
          data={this.state.medicos}
          keyExtractor={item => item.idMedico}
          renderItem={({ item }) => (
            <View>
              <Text>{item.nome}</Text>
              <Text>{item.dataNascimento}</Text>
              <Text>{item.crm}</Text>
              <Text>{item.areaAtuacao}</Text>
              <Text>{item.ativo}</Text>
            </View>
          )}
        />
      </View>
    );
  }
}

export default Home;