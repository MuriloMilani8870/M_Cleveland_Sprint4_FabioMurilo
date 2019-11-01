import {createAppContainer, createSwitchNavigator} from 'react-navigation';
import {createBottomTabNavigator} from 'react-navigation-tabs';
import HomeScreen from './pages/Home';

const MainNavigator = createBottomTabNavigator(
    {
        Home: {
            screen: HomeScreen,
        },
    },
);

export default createAppContainer(createSwitchNavigator(
  {
    MainNavigator
  }, 
));