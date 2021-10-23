import React from 'react';
import { Route, Switch } from 'react-router-dom';
import * as Components from './index';

function SecondPage() {
    return (
        <div>
            <h1>AnotherPage</h1>
        </div>
    )
}

const Routes = () => {
    return (
        <main>
            <Switch>
                <Route path='/' component={() => Components.ExampleComponent()} />

                <Route exact path='/another' component={() =>
                    <div>
                        <SecondPage/>
                    </div>} />
            </Switch>
        </main>
    )
}

export default Routes