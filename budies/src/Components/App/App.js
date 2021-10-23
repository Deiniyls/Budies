import { withRouter } from 'react-router-dom'
import Routes from '../router'
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div>
      <Routes />
    </div>
  );
}

export default withRouter(App);
