import React, { Component } from 'react';
class QuantityUnitType extends Component {
    
    render() {
        return (
            <select className='select-type'  onChange={this.props.quantityUnitTypeChanged}>
                <option value="-1" selected>Select</option>
                <option name="length">Length</option>
                <option name="weight">Weight</option>
            </select>
        )
    }
}
export default QuantityUnitType;